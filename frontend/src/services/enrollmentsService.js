import axiosInstance from "../httpClient/axiosInstance";

export function getPaginatedEnrollments(request) {
  const queryParams = new URLSearchParams(request).toString();
  return axiosInstance.get(`/enrollments?${queryParams}`);
}
export function createEnrollment(request) {
  return axiosInstance.post("/users", request);
}

export function getEnrollmentById(userId) {
  return axiosInstance.get(`/users/${userId}`);
}

export function updateEnrollment(userId, request) {
  return axiosInstance.put(`/users/${userId}`, request);
}

export function checkEnrollmentValidForDelete(userId) {
  return axiosInstance.post(`/users/isValidDeletedUser/${userId}`);
}

export function deleteEnrollment(userId) {
  return axiosInstance.delete(`/users/${userId}`);
}
