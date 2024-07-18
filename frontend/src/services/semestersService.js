import axiosInstance from "../httpClient/axiosInstance";

export function getPaginatedSemesters(request) {
    const queryParams = new URLSearchParams(request).toString();
    return axiosInstance.get(`/semesters?${queryParams}`);
}

export function createSemester(request) {
    return axiosInstance.post(`/semesters`, request);
} 