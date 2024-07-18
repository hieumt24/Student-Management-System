import axios from "axios";

const axiosInstance = axios.create({
  baseURL: "http://localhost:5000/api/v1",
});

axiosInstance.interceptors.request.use(
  (config) => {
    const token = localStorage.getItem("token");
    if (token) {
      config.headers.Authorization = `Bearer ${token}`;
    }
    return config;
  },
  (error) => {
    return Promise.reject(error);
  },
);

axiosInstance.interceptors.response.use(
  (res) => {
    return res;
    // return {data: res?.data, status: res.status};
  },
  async (error) => {
    if (error.response.status === 401) {
      localStorage.removeItem("token");
      localStorage.setItem("unauthorized", "true");
      
      if (window.location.pathname !== "/auth/login") {
        window.location.href = "/auth/login";
      }
        

      return Promise.reject(error.response.data);
    }
    return Promise.reject(error);
  },
);

export default axiosInstance;
