import React, { useEffect, useState } from "react";
import { FaSearch, FaFileExcel } from "react-icons/fa";
import { Pagination } from "../../components/Pagination";
import { useAuth } from "../../hooks";
import { getPaginatedStudentEnrollments, exportStudentEnrollmentsToExcel } from "../../services";

const EnrollmentState = {
    1: "Enrolled",
    2: "Passed",
    3: "Failed",
};

const stateColors = {
    Enrolled: "bg-yellow-200 text-yellow-800",
    Passed: "bg-green-200 text-green-800",
    Failed: "bg-red-200 text-red-800",
};

export const StudentEnrollmentsList = () => {
    const [enrollments, setEnrollments] = useState([]);
    const [pagination, setPagination] = useState({
        pageIndex: 1,
        pageCount: 0,
        pageSize: 10,
        totalRecords: 0,
    });
    const [searchQuery, setSearchQuery] = useState("");
    const [sortConfig, setSortConfig] = useState({ key: "", direction: "" });
    const { user } = useAuth();

    useEffect(() => {
        fetchEnrollments();
    }, [pagination.pageIndex, pagination.pageSize, searchQuery, sortConfig]);

    const fetchEnrollments = () => {
        getPaginatedStudentEnrollments({
            PageIndex: pagination.pageIndex,
            PageSize: pagination.pageSize,
            search: searchQuery,
            orderBy: sortConfig.key,
            isDescending: sortConfig.direction === "descending",
            studentId: user.id, // Assuming the user object has an id field
        })
            .then((response) => {
                setEnrollments(response.data.data || []);
                setPagination({
                    ...pagination,
                    pageCount: response.data.totalPages,
                    totalRecords: response.data.totalRecords,
                });
            })
            .catch((err) => {
                console.error("Error fetching enrollments:", err);
            });
    };

    const handleSort = (key) => {
        let direction = "ascending";
        if (sortConfig.key === key && sortConfig.direction === "ascending") {
            direction = "descending";
        }
        setSortConfig({ key, direction });
    };

    const handleSearch = (e) => {
        setSearchQuery(e.target.value);
        setPagination({ ...pagination, pageIndex: 1 });
    };

    const exportToExcel = () => {
        exportStudentEnrollmentsToExcel(user.id, user.token)
            .then(response => {
                const url = window.URL.createObjectURL(new Blob([response.data]));
                const link = document.createElement('a');
                link.href = url;
                link.setAttribute('download', 'grades.xlsx');
                document.body.appendChild(link);
                link.click();
                link.parentNode.removeChild(link);
            })
            .catch(error => console.error('Error downloading the file:', error));
    };

    return (
        <div className="container mx-auto px-4 py-8">
            <h1 className="text-2xl font-bold mb-4">Your Grade</h1>
            <div className="mb-4 flex justify-between items-center">
                <div className="relative">
                    <input
                        type="text"
                        placeholder="Search course code"
                        value={searchQuery}
                        onChange={handleSearch}
                        className="pl-10 pr-4 py-2 border rounded-lg focus:outline-none focus:ring-2 focus:ring-blue-500"
                    />
                    <FaSearch className="absolute left-3 top-1/2 transform -translate-y-1/2 text-gray-400" />
                </div>
                <button
                    onClick={exportToExcel}
                    className="bg-green-500 hover:bg-green-700 text-white font-bold py-2 px-4 rounded inline-flex items-center"
                >
                    <FaFileExcel className="mr-2" />
                    Export to Excel
                </button>
            </div>
            <div className="bg-white shadow-lg rounded-lg overflow-auto border border-gray-200">
                <table className="min-w-full divide-y divide-gray-200">
                    <thead className="bg-gray-50">
                        <tr>
                            {["courseCode", "semesterCode", "grade", "state"].map((key) => (
                                <th
                                    key={key}
                                    onClick={() => handleSort(key)}
                                    className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider cursor-pointer"
                                >
                                    {key.charAt(0).toUpperCase() + key.slice(1)}{" "}
                                    {sortConfig.key === key &&
                                        (sortConfig.direction === "ascending" ? "▲" : "▼")}
                                </th>
                            ))}
                        </tr>
                    </thead>
                    <tbody className="bg-white divide-y divide-gray-200">
                        {enrollments.length > 0 ? (
                            enrollments.map((enrollment, index) => (
                                <tr
                                    key={enrollment.id}
                                    className={index % 2 === 0 ? "bg-gray-50" : "bg-white"}
                                >
                                    <td className="px-6 py-4 whitespace-nowrap text-sm text-gray-900">
                                        {enrollment.courseCode}
                                    </td>

                                    <td className="px-6 py-4 whitespace-nowrap text-sm text-gray-900">
                                        {enrollment.semesterCode}
                                    </td>
                                    <td className="px-6 py-4 whitespace-nowrap text-sm text-gray-900">
                                        {enrollment.grade}
                                    </td>
                                    <td className="px-6 py-4 whitespace-nowrap text-sm">
                                        <span className={`px-2 inline-flex text-xs leading-5 font-semibold rounded-full ${stateColors[EnrollmentState[enrollment.state]]}`}>
                                            {EnrollmentState[enrollment.state]}
                                        </span>
                                    </td>
                                </tr>
                            ))
                        ) : (
                            <tr>
                                <td
                                    colSpan={5}
                                    className="px-6 py-4 whitespace-nowrap text-sm text-gray-500 text-center"
                                >
                                    No enrollments found
                                </td>
                            </tr>
                        )}
                    </tbody>
                </table>
            </div>
            <div className="mt-4">
                <Pagination
                    {...pagination}
                    setPage={(page) => {
                        setPagination({ ...pagination, pageIndex: page });
                    }}
                />
            </div>
        </div>
    );
};
