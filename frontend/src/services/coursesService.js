import axiosInstance from "../httpClient/axiosInstance";

export function getPaginatedCourses(request) {
    const queryParams = new URLSearchParams(request).toString();
    return axiosInstance.get(`/courses?${queryParams}`);
}

export function createCourse(request) {
    return axiosInstance.post(`/courses`, request);
} 