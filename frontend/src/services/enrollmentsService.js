import axiosInstance from "../httpClient/axiosInstance";

export function getPaginatedEnrollments(request) {
  const queryParams = new URLSearchParams(request).toString();
  return axiosInstance.get(`/enrollments?${queryParams}`);
}
export function createEnrollment(request) {
  return axiosInstance.post("/enrollments", request);
}

export function getEnrollmentById(enrollmentId) {
  return axiosInstance.get(`/enrollments/${enrollmentId}`);
}

export function updateEnrollment(enrollmentId, request) {
  return axiosInstance.put(`/enrollments/${enrollmentId}`, request);
}

export function checkEnrollmentValidForDelete(enrollmentId) {
  return axiosInstance.post(`/enrollments/isValidDeletedUser/${enrollmentId}`);
}

export function deleteEnrollment(enrollmentId) {
  return axiosInstance.delete(`/enrollments/${enrollmentId}`);
}
