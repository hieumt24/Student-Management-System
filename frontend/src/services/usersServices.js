import axiosInstance from "../httpClient/axiosInstance";

export function getPaginatedUsers(request) {
    axiosInstance.get(`/users?PageIndex=${request.pageIndex}`)
}