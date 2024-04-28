
export interface Assignment {
  assignmentId: number | null;
  question: string | null;
  allotedDate: string  | null;
  targetDate: Date  | null;
  courseId: number  | null;
  course: Course  | null;
  subjectId: number  | null;
  subject: Subject  | null;
  studentId: number  | null;
  student: Student  | null;
  facultyId: number  | null;
  faculty: Faculty  | null;
}
export interface AssignmentSubmission {
  submissionId: number | null;
  answer: string  | null;
  status: number  | null;
  feedback: string  | null;
  reviewed: boolean  | null;
  submissionDate: string  | null;
  assignmentId: number  | null;
  assignment: Assignment  | null;
  studentId: number  | null;
  student: Student  | null;
  courseId: number  | null;
  course: Course  | null;
  subjectId: number  | null;
  subject: Subject  | null;
}

export interface Attendance {
  attendanceId: number | null;
  attendanceDate: Date | null;
  isPresent: boolean | null;
  studentId: number  | null;
  student: Student  | null;
  facultyId: number  | null;
  faculty: Faculty  | null;
}
export interface Student {
  studentId: number | null;
  studentDepartment: string | null;
  studentYear: string | null;
  mailId: string | null;
  mobileNumber: string  | null;
  address: string  | null;
  fullName: string | null;
  userId: number  | null;
  user: User  | null;
}
export interface Calendar {
  calendarId: number | null;
  message: string | null;
  targetDate: string  | null;
  status: string | null;
  reason: string | null;
}
export interface Course {
  courseId: number | null;
  courseName: string | null;
}
export interface Faculty {
  facultyId: number | null;
  facultyDepartment: string | null;
  mailId: string | null;
  mobileNumber: string  | null;
  address: string  | null;
  userId: number  | null;
  user: User  | null;
  fullName: string | null;
}
export interface FacultySubjects {
  id: number | null;
  subjectId: number  | null;
  subject: Subject  | null;
  facultyId: number  | null;
  faculty: Faculty  | null;
}
export interface FeeDetail {
  feeId: number | null;
  amount: number | null;
  feeName: string | null;
  dueDate: Date | null;
  paymentDate: Date  | null;
  hasPaid: boolean | null;
  studentId: number  | null;
  student: Student  | null;
}
export interface HomePageDetail {
  id: number | null;
  key: string  | null;
  value: string  | null;
}
export interface IssueReport {
  ticketId: number | null;
  description: string | null;
  isResolved: boolean | null;
  userId: number  | null;
  user: User  | null;
}
export interface LeaveDetail {
  id: number | null;
  reason: string | null;
  dateOfLeave: Date | null;
  isApproved: boolean | null;
  userId: number | null;
  user: User  | null;
}
export interface Parent {
  parentId: number | null;
  mailId: string | null;
  mobileNumber: string  | null;
  address: string  | null;
  userId: number  | null;
  user: User  | null;
  fullName: string | null;
}
export interface Student {
  studentId: number | null;
  studentDepartment: string | null;
  studentYear: string | null;
  mailId: string | null;
  mobileNumber: string  | null;
  address: string  | null;
  fullName: string | null;
  userId: number  | null;
  user: User  | null;
}
export interface StudentCourse {
  id: number | null;
  courseId: number  | null;
  course: Course  | null;
  studentId: number  | null;
  student: Student  | null;
}
export interface Subject {
  subjectId: number | null;
  subjectName: string | null;
  courseId: number  | null;
  course: Course | null;
}
export interface User {
  userId: number | null;
  userName: string | null;
  password: string | null;
  email: string | null;
  firstName: string | null;
  lastName: string | null;
  userType: string | null;
}
export interface UserDto {
  userName?: string | null;
  password?: string | null;
  oldPassword?: string | null;
  mailId?: string | null;
  mobileNumber?: string | null;
  address?: string | null;
  firstName?: string | null;
  lastName?: string | null;
  studentYear?: string | null;
  userType?: string | null;
  department?: string | null;
  fullName?: string | null;
  userId?: number | null;
}
