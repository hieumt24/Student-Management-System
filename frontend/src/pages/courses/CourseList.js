import React, { useEffect, useState } from "react";
import { FaPlus, FaSearch } from "react-icons/fa";
import { useNavigate } from "react-router-dom";
import { Pagination } from "../../components/Pagination";
import { CourseCard } from "../../components/courses";
import { useAuth } from "../../hooks";
import { getPaginatedCourses } from "../../services";

export const CourseList = () => {
  const {user} = useAuth();
  const [courses, setCourses] = useState([]);
  const [pagination, setPagination] = useState({
    pageIndex: 1,
    pageCount: 0,
    pageSize: 9,
    totalRecords: 0,
  });
  const [searchQuery, setSearchQuery] = useState("");
  const [sortConfig, setSortConfig] = useState({ key: "", direction: "" });
  const navigate = useNavigate();

  useEffect(() => {
    fetchCourses();
  }, [pagination.pageIndex, pagination.pageSize, searchQuery, sortConfig]);

  const fetchCourses = async () => {
    try {
      const response = await getPaginatedCourses({
        PageIndex: pagination.pageIndex,
        PageSize: pagination.pageSize,
        search: searchQuery,
        orderBy: sortConfig.key,
        isDescending: sortConfig.direction === "descending",
      });
      setCourses(response.data.data || []);
      setPagination({
        ...pagination,
        pageCount: response.data.totalPages,
        totalRecords: response.data.totalRecords,
      });
    } catch (error) {
      console.error("Error fetching courses:", error);
    }
  };

  const handleSort = (e) => {
    const [key, direction] = e.target.value.split(",");
    setSortConfig({ key, direction });
  };

  const handleSearch = (e) => {
    setSearchQuery(e.target.value);
    setPagination({ ...pagination, pageIndex: 1 });
  };

  const handleCreateCourse = () => {
    navigate("/courses/create");
  };

  return (
    <div className="container mx-auto px-4 py-8">
      <div className="mb-6 flex justify-between items-center">
        <h1 className="text-3xl font-bold text-gray-800">Courses</h1>
        <div className="flex items-center">
          <div className="relative mr-4">
            <input
              type="text"
              placeholder="Search courses"
              value={searchQuery}
              onChange={handleSearch}
              className="pl-10 pr-4 py-2 border rounded-lg focus:outline-none focus:ring-2 focus:ring-blue-500"
            />
            <FaSearch className="absolute left-3 top-1/2 transform -translate-y-1/2 text-gray-400" />
          </div>
          {user.role === "Admin" && (<button
            onClick={handleCreateCourse}
            className="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded flex items-center transition duration-300"
          >
            <FaPlus className="mr-2" /> Create Course
          </button>)}
        </div>
      </div>
      <div className="mb-4 flex justify-end">
        <select
          onChange={handleSort}
          className="mr-2 px-3 py-2 border rounded-lg focus:outline-none focus:ring-2 focus:ring-blue-500"
        >
          <option value="">Sort by</option>
          <option value="Title,ascending">Title(A-Z)</option>
          <option value="Title,descending">Title (Z-A)</option>
          <option value="CourseCode,ascending">Course Code (A-Z)</option>
          <option value="CourseCode,descending">Course Code (Z-A)</option>
          <option value="Credits,ascending">Credits Asc</option>
          <option value="Credits,descending">Credits Des</option>
        </select>
      </div>
      <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
        {courses.length > 0 ? (
          courses.map((course) => (
            <CourseCard course={course} key={course.id} enroll={user.role === "Student"}/>
          ))
        ) : (
          <div className="col-span-3 text-center text-gray-500">
            No courses found
          </div>
        )}
      </div>
      <div className="mt-6">
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
