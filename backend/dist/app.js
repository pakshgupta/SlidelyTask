import express from 'express';
import bodyParser from 'body-parser';
import submissionRoute from './router/form.route.js';
import cors from 'cors';
const port = 3000;
const app = express();
app.use(bodyParser.json());
app.use(cors());
app.use('/api/v1', submissionRoute);
app.listen(port, () => {
    console.log(`server is working on ${port}`);
});
