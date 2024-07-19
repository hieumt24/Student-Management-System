import React, { useEffect, useState } from "react";
import { Pagination } from "../../components/Pagination";
import { getPaginatedSemesters } from "../../services/semestersService";
import { useNavigate } from "react-router-dom";

export const SemesterList = () => {
    const [semesters, setSemesters] = useState([]);
    const [pagination, setPagination] = useState({
        pageIndex: 1,
        pageCount: 0,
        pageSize: 10,
        totalRecords: 0,
    });
    const [searchQuery, setSearchQuery] = useState("");
    const [sortConfig, setSortConfig] = useState({ key: "", direction: "" });
    const navigate = useNavigate();

    useEffect(() => {
        fetchSemesters();
    }, [pagination.pageIndex, pagination.pageSize, searchQuery, sortConfig]);

    const fetchSemesters = () => {
        getPaginatedSemesters({
            PageIndex: pagination.pageIndex,
            PageSize: pagination.pageSize,
            search: searchQuery,
            orderBy: sortConfig.key,
            isDescending: sortConfig.direction === "descending",
        })
            .then((response) => {
                setSemesters(response.data.data || []);
                setPagination({
                    ...pagination,
                    pageCount: response.data.totalPages,
                    totalRecords: response.data.totalRecords,
                });
            })
            .catch((err) => {
                console.log(err);
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

    const handleCreateSemester = () => {
        navigate("/semesters/create");
    };

    return (
        <div className="container mx-auto px-4 py-8">
            <div className="mb-4 flex justify-between items-center">
                <input
                    type="text"
                    placeholder="Search by Semester Code"
                    value={searchQuery}
                    onChange={handleSearch}
                    className="px-4 py-2 border rounded-lg"
                />
                <button
                    onClick={handleCreateSemester}
                    className="bg-green-500 hover:bg-green-700 text-white font-bold py-2 px-4 rounded"
                >
                    Create Semester
                </button>
            </div>
            <div className="bg-white shadow-lg rounded-lg overflow-hidden border border-gray-200">
                <table className="min-w-full divide-y divide-gray-200">
                    <thead className="bg-gray-50">
                        <tr>
                            <th onClick={() => handleSort("semesterCode")} className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider cursor-pointer">
                                Semester Code {sortConfig.key === "semesterCode" && (sortConfig.direction === "ascending" ? "▲" : "▼")}
                            </th>
                            <th onClick={() => handleSort("semesterName")} className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider cursor-pointer">
                                Semester Name {sortConfig.key === "semesterName" && (sortConfig.direction === "ascending" ? "▲" : "▼")}
                            </th>
                            <th onClick={() => handleSort("academicYear")} className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider cursor-pointer">
                                Academic Year {sortConfig.key === "academicYear" && (sortConfig.direction === "ascending" ? "▲" : "▼")}
                            </th>
                            <th className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider">Action</th>
                        </tr>
                    </thead>
                    <tbody className="bg-white divide-y divide-gray-200">
                        {semesters.length > 0 ? (
                            semesters.map((semester, index) => (
                                <tr key={semester.id} className={index % 2 === 0 ? 'bg-gray-50' : 'bg-white'}>
                                    <td className="px-6 py-4 whitespace-nowrap text-sm text-gray-500">{semester.semesterCode}</td>
                                    <td className="px-6 py-4 whitespace-nowrap text-sm text-gray-900">{semester.semesterName}</td>
                                    <td className="px-6 py-4 whitespace-nowrap text-sm text-gray-900">{semester.academicYear}</td>
                                    <td className="px-6 py-4 whitespace-nowrap text-sm font-medium">
                                        <button className="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded mr-2">
                                            Edit
                                        </button>
                                        <button className="bg-red-500 hover:bg-red-700 text-white font-bold py-2 px-4 rounded">
                                            Delete
                                        </button>
                                    </td>
                                </tr>
                            ))
                        ) : (
                            <tr>
                                <td colSpan={5} className="px-6 py-4 whitespace-nowrap text-sm text-gray-500 text-center">
                                    No semesters found
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