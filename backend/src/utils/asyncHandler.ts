import { Request, Response, NextFunction } from "express";

type RequestHandler = (
  req: Request,
  res: Response,
  next: NextFunction
) => Promise<any> | any;

export const asyncHandler = (requestHandler: RequestHandler) => {
  return (req: Request, res: Response, next: NextFunction) => {
    Promise.resolve(requestHandler(req, res, next)).catch((error) =>
      next(error)
    );
  };
};
