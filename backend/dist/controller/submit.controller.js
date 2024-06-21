import fs from "fs";
import { fileURLToPath } from 'url';
import path from "path";
import { ApiError } from "../utils/ApiError.js";
import { ApiResponse } from "../utils/ApiResponse.js";
import { asyncHandler } from "../utils/asyncHandler.js";
const __filename = fileURLToPath(import.meta.url);
if (!__filename) {
    throw new ApiError(400, "Invalid file name");
}
const __dirname = path.dirname(__filename);
if (!__dirname) {
    throw new ApiError(400, "Invalid directory name");
}
const dbFilePath = path.join(__dirname, '..', '..', 'src', 'db.json');
if (!dbFilePath) {
    throw new ApiError(400, "Invalid db file name");
}
const loadSubmission = () => {
    const data = fs.readFileSync(dbFilePath, 'utf8');
    return JSON.parse(data);
};
const saveSubmission = (submissions) => {
    fs.writeFileSync(dbFilePath, JSON.stringify(submissions, null, 2));
};
export const submitController = asyncHandler(async (req, res) => {
    const { name, email, phone, github_link, stopwatch_time } = req.body;
    if ([name, email, phone, github_link, stopwatch_time].some((field) => field.trim === ""))
        throw new ApiError(400, "All feilds are required");
    const newSubmission = { name, email, phone, github_link, stopwatch_time };
    const submissions = loadSubmission();
    submissions.push(newSubmission);
    saveSubmission(submissions);
    return res
        .status(200)
        .json(new ApiResponse(200, "Data submitted successfully"));
});
export const readSubmission = asyncHandler(async (req, res) => {
    const index = parseInt(req.query.index, 10);
    const submission = loadSubmission();
    if (isNaN(index) || index < 0 || index >= submission.length) {
        throw new ApiError(400, "Invalid Index");
    }
    return res.status(200).json(submission[index]);
});
export const statusController = asyncHandler(async (req, res) => {
    res.send(true);
});
export const deleteSubmission = asyncHandler(async (req, res) => {
    const index = parseInt(req.query.index, 10);
    const submissions = loadSubmission();
    if (isNaN(index) || index < 0 || index >= submissions.length) {
        throw new ApiError(400, 'Invalid Index');
    }
    const deletedSubmission = submissions.splice(index, 1);
    saveSubmission(submissions);
    return res.status(200).json(new ApiResponse(200, 'Submission deleted successfully', deletedSubmission));
});
export const updateSubmission = asyncHandler(async (req, res) => {
    const index = parseInt(req.query.index, 10);
    const { name, email, phone, github_link, stopwatch_time } = req.body;
    const submissions = loadSubmission();
    if (isNaN(index) || index < 0 || index >= submissions.length) {
        throw new ApiError(400, 'Invalid Index');
    }
    if ([name, email, phone, github_link, stopwatch_time].some((field) => field.trim() === '')) {
        throw new ApiError(400, 'All fields are required');
    }
    submissions[index] = {
        name,
        email,
        phone,
        github_link,
        stopwatch_time,
    };
    saveSubmission(submissions);
    return res
        .status(200)
        .json(new ApiResponse(200, 'Submission updated successfully', submissions[index]));
});
export const searchByEmail = asyncHandler(async (req, res) => {
    const { email } = req.query;
    if (!email || typeof email !== 'string' || email.trim() === '') {
        throw new ApiError(400, 'Invalid email query parameter');
    }
    const submissions = loadSubmission();
    const foundSubmissions = submissions.filter((submission) => submission.email === email);
    return res.status(200).json(new ApiResponse(200, 'Search results', foundSubmissions));
});
