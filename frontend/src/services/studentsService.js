import axiosInstance from "../httpClient/axiosInstance";

export const getPaginatedStudentEnrollments = (params) => {
    return axiosInstance.get('/students/enrollments', { params });
};

export const exportStudentEnrollmentsToExcel = (studentId, token) => {
    const url = `/students/exports?studentId=${studentId}`;
    return axiosInstance.get(url, {
        headers: {
            'Accept': 'application/json',
            'Authorization': `Bearer ${token}`
        },
        responseType: 'blob'
    });
};