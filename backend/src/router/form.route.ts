import { Router } from "express";
import {
    deleteSubmission,
  readSubmission,
  searchByEmail,
  statusController,
  submitController,
  updateSubmission,
} from "../controller/submit.controller.js";
const router = Router();
router.route("/ping").get(statusController);
router.route("/submit").post(submitController);
router.route("/read").get(readSubmission);
router.route('/delete').delete(deleteSubmission);
router.route('/update').put(updateSubmission);
router.route('/search').get(searchByEmail);
export default router;
