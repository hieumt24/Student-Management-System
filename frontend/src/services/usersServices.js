import axiosInstance from "../httpClient/axiosInstance";

export function getPaginatedUsers(request) {
  const queryParams = new URLSearchParams(request).toString();
  return axiosInstance.get(`/users?${queryParams}`);
}

export function createUser(request) {
  return axiosInstance.post("/users", request);
}

export function getUserById(userId) {
  return axiosInstance.get(`/users/${userId}`);
}

export function updateUser(userId, request) {
  return axiosInstance.put(`/users/${userId}`, request);
}
