import axiosInstance from "../httpClient/axiosInstance";

export const login = (form) => {
    const emailReg = /^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$/g;
    if (emailReg.test(form.usernameOrEmail)) {
        return axiosInstance.post("/auth/login", {username: "", email: form.usernameOrEmail, password: form.password});
    }
    return axiosInstance.post("/auth/login", {username: form.usernameOrEmail, email: "", password: form.password});
}   