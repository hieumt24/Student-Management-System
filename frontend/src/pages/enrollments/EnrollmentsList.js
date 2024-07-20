import React, { useEffect, useState } from "react";
import { FaSearch } from "react-icons/fa";
import { useNavigate } from "react-router-dom";
import { toast } from "react-toastify";
import { Pagination } from "../../components/Pagination";
import { useAuth } from "../../hooks";
import { getPaginatedEnrollments } from "../../services/enrollmentsService";

// Utility function to format date
const formatDate = (dateStr) => {
  const date = new Date(dateStr);
  const year = date.getFullYear();
  const month = String(date.getMonth() + 1).padStart(2, "0");
  const day = String(date.getDate()).padStart(2, "0");
  return `${year}/${month}/${day}`;
};

const EnrollmentState = {
  1: "Enrolled",
  2: "Passed",
  3: "Failed",
};

const stateColors = {
  Enrolled: "bg-yellow-200",
  Passed: "bg-green-600",
  Failed: "bg-red-600",
};

export const EnrollmentsList = () => {
  const [enrollments, setEnrollments] = useState([]);
  const [pagination, setPagination] = useState({
    pageIndex: 1,
    pageCount: 0,
    pageSize: 10,
    totalRecords: 0,
  });
  const [searchQuery, setSearchQuery] = useState("");
  const [sortConfig, setSortConfig] = useState({ key: "", direction: "" });
  const navigate = useNavigate();
  const { user } = useAuth();

  const fetchEnrollments = () => {
    getPaginatedEnrollments({
      PageIndex: pagination.pageIndex,
      PageSize: pagination.pageSize,
      search: searchQuery,
      orderBy: sortConfig.key,
      isDescending: sortConfig.direction === "descending",
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
        console.log(err);
      });
  };

  useEffect(() => {
    fetchEnrollments();
  }, [pagination.pageIndex, pagination.pageSize, searchQuery, sortConfig]);

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

  return (
    <div className="container mx-auto px-4 py-8">
      <div className="mb-4 flex justify-between items-center">
        <div className="relative">
          <input
            type="text"
            placeholder="Search enrollments"
            value={searchQuery}
            onChange={handleSearch}
            className="pl-10 pr-4 py-2 border rounded-lg focus:outline-none focus:ring-2 focus:ring-blue-500"
          />
          <FaSearch className="absolute left-3 top-1/2 transform -translate-y-1/2 text-gray-400" />
        </div>
      </div>
      <div className="bg-white shadow-lg rounded-lg overflow-auto border border-gray-200">
        <table className="min-w-full divide-y divide-gray-200">
          <thead className="bg-gray-50">
            <tr>
              <th
                onClick={() => handleSort("studentCode")}
                className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider cursor-pointer"
              >
                Student Code{" "}
                {sortConfig.key === "studentCode" &&
                  (sortConfig.direction === "ascending" ? "▲" : "▼")}
              </th>
              <th
                onClick={() => handleSort("studentName")}
                className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider cursor-pointer"
              >
                Student Name{" "}
                {sortConfig.key === "studentName" &&
                  (sortConfig.direction === "ascending" ? "▲" : "▼")}
              </th>
              <th
                onClick={() => handleSort("courseCode")}
                className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider cursor-pointer"
              >
                Course Code{" "}
                {sortConfig.key === "courseCode" &&
                  (sortConfig.direction === "ascending" ? "▲" : "▼")}
              </th>
              <th
                onClick={() => handleSort("semesterCode")}
                className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider cursor-pointer"
              >
                Semester Code{" "}
                {sortConfig.key === "semesterCode" &&
                  (sortConfig.direction === "ascending" ? "▲" : "▼")}
              </th>
              <th
                onClick={() => handleSort("grade")}
                className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider cursor-pointer"
              >
                Grade{" "}
                {sortConfig.key === "grade" &&
                  (sortConfig.direction === "ascending" ? "▲" : "▼")}
              </th>
              <th
                onClick={() => handleSort("isPassed")}
                className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider cursor-pointer"
              >
                Passed{" "}
                {sortConfig.key === "isPassed" &&
                  (sortConfig.direction === "ascending" ? "▲" : "▼")}
              </th>
              <th
                onClick={() => handleSort("state")}
                className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider cursor-pointer"
              >
                State{" "}
                {sortConfig.key === "state" &&
                  (sortConfig.direction === "ascending" ? "▲" : "▼")}
              </th>
              <th className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider">
                Action
              </th>
            </tr>
          </thead>
          <tbody className="bg-white divide-y divide-gray-200">
            {enrollments.length > 0 ? (
              enrollments.map((enrollment, index) => (
                <tr
                  key={index}
                  className={index % 2 === 0 ? "bg-gray-50" : "bg-white"}
                >
                  <td className="px-6 py-4 whitespace-nowrap text-sm text-gray-500">
                    {enrollment.studentCode}
                  </td>
                  <td className="px-6 py-4 whitespace-nowrap text-sm text-gray-900">
                    {enrollment.studentName}
                  </td>
                  <td className="px-6 py-4 whitespace-nowrap text-sm text-gray-900">
                    {enrollment.courseCode}
                  </td>
                  <td className="px-6 py-4 whitespace-nowrap text-sm text-gray-900">
                    {enrollment.semesterCode}
                  </td>
                  <td className="px-6 py-4 whitespace-nowrap text-sm text-gray-900">
                    {enrollment.grade}
                  </td>
                  <td className="px-6 py-4 whitespace-nowrap text-sm text-gray-900">
                    {enrollment.isPassed ? "Yes" : "No"}
                  </td>
                  <td
                    className={`px-6 py-4 whitespace-nowrap text-sm text-gray-900 ${
                      stateColors[EnrollmentState[enrollment.state]]
                    }`}
                  >
                    {EnrollmentState[enrollment.state]}
                  </td>
                  <td className="px-6 py-4 whitespace-nowrap text-sm font-medium">
                    <button
                      className="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded mr-2"
                      onClick={() => {
                        navigate(`edit/${enrollment.id}`);
                      }}
                    >
                      Edit
                    </button>
                  </td>
                </tr>
              ))
            ) : (
              <tr>
                <td
                  colSpan={8}
                  className="px-6 py-4 whitespace-nowrap text-sm text-gray-500 text-center"
                >
                  No result
                </td>
              </tr>
            )}
          </tbody>
        </table>
      </div>
      <Pagination
        {...pagination}
        setPage={(page) => {
          setPagination({ ...pagination, pageIndex: page });
        }}
      />
    </div>
  );
};
