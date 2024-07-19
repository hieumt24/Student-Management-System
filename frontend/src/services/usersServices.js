import axiosInstance from "../httpClient/axiosInstance";

export function getPaginatedUsers(request) {
    const queryParams = new URLSearchParams(request).toString();
    return axiosInstance.get(`/users?${queryParams}`);
}

export function createUser(request) {
    return axiosInstance.post("/users", request); 
}