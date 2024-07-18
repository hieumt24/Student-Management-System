import axiosInstance from "../httpClient/axiosInstance";

export const login = (form) => {
    return axiosInstance.post("/auth/login", form);
}