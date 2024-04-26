
export interface Assignment {
  assignmentId: number;
  allotedDate: string | null;
  targetDate: Date | null;
  courseId: number | null;
  course: Course | null;
  subjectId: number | null;
  subject: Subject | null;
  studentId: number | null;
  student: Student | null;
  facultyId: number | null;
  faculty: Faculty | null;
}
export interface AssignmentSubmission {
  submissionId: number;
  answer: string | null;
  status: number | null;
  feedback: string | null;
  reviewed: boolean | null;
  submissionDate: string | null;
  assignmentId: number | null;
  assignment: Assignment | null;
  studentId: number | null;
  student: Student | null;
  courseId: number | null;
  course: Course | null;
  subjectId: number | null;
  subject: Subject | null;
}

export interface Attendance {
  attendanceId: number;
  attendanceDate: Date;
  isPresent: boolean;
  studentId: number | null;
  student: Student | null;
  facultyId: number | null;
  faculty: Faculty | null;
}
export interface Student {
  studentId: number;
  studentDepartment: string;
  studentYear: string;
  mailId: string;
  mobileNumber: string | null;
  address: string | null;
  fullName: string;
  userId: number | null;
  user: User | null;
}
export interface Calendar {
  calendarId: number;
  message: string;
  targetDate: string | null;
  status: string;
  reason: string;
}
export interface Course {
  courseId: number;
  courseName: string;
}
export interface Faculty {
  facultyId: number;
  facultyDepartment: string;
  mailId: string;
  mobileNumber: string | null;
  address: string | null;
  userId: number | null;
  user: User | null;
  fullName: string;
}
export interface FacultySubjects {
  id: number;
  subjectId: number | null;
  subject: Subject | null;
  facultyId: number | null;
  faculty: Faculty | null;
}
export interface FeeDetail {
  feeId: number;
  amount: number;
  feeName: string;
  dueDate: Date;
  paymentDate: Date | null;
  hasPaid: boolean;
  studentId: number | null;
  student: Student | null;
}
export interface HomePageDetail {
  id: number;
  key: string | null;
  value: string | null;
}
export interface IssueReport {
  ticketId: number;
  description: string;
  isResolved: boolean;
  userId: number | null;
  user: User | null;
}
export interface LeaveDetail {
  id: number;
  reason: string;
  dateOfLeave: Date;
  isApproved: boolean;
  userId: number;
  user: User | null;
}
export interface Parent {
  parentId: number;
  mailId: string;
  mobileNumber: string | null;
  address: string | null;
  userId: number | null;
  user: User | null;
  fullName: string;
}
export interface Student {
  studentId: number;
  studentDepartment: string;
  studentYear: string;
  mailId: string;
  mobileNumber: string | null;
  address: string | null;
  fullName: string;
  userId: number | null;
  user: User | null;
}
export interface StudentCourse {
  id: number;
  courseId: number | null;
  course: Course | null;
  studentId: number | null;
  student: Student | null;
}
export interface Subject {
  subjectId: number;
  subjectName: string;
  courseId: number | null;
  course: Course;
}
export interface User {
  userId: number;
  userName: string;
  password: string;
  email: string;
  firstName: string;
  lastName: string;
  userType: string;
}
