import React, { useEffect, useState } from "react";
import { Pagination } from "../../components/Pagination";
import { getPaginatedUsers } from "../../services/usersServices";
import { FaSearch, FaPlus } from "react-icons/fa";
import { useNavigate } from "react-router-dom";

export const UsersList = () => {
  const [users, setUsers] = useState([]);
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
    fetchUsers();
  }, [pagination.pageIndex, pagination.pageSize, searchQuery, sortConfig]);

  const fetchUsers = () => {
    getPaginatedUsers({
      PageIndex: pagination.pageIndex,
      PageSize: pagination.pageSize,
      search: searchQuery,
      orderBy: sortConfig.key,
      isDescending: sortConfig.direction === "descending",
      location: 1,
    })
      .then((response) => {
        setUsers(response.data.data || []);
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

  const handleCreateUser = () => {
    navigate("/users/create");
  };

  return (
    <div className="container mx-auto px-4 py-8">
      <div className="mb-4 flex justify-between items-center">
        <div className="relative">
          <input
            type="text"
            placeholder="Search users"
            value={searchQuery}
            onChange={handleSearch}
            className="pl-10 pr-4 py-2 border rounded-lg focus:outline-none focus:ring-2 focus:ring-blue-500"
          />
          <FaSearch className="absolute left-3 top-1/2 transform -translate-y-1/2 text-gray-400" />
        </div>
        <button
          onClick={handleCreateUser}
          className="bg-green-500 hover:bg-green-700 text-white font-bold py-2 px-4 rounded flex items-center"
        >
          <FaPlus className="mr-2" /> Create User
        </button>
      </div>
      <div className="bg-white shadow-lg rounded-lg overflow-hidden border border-gray-200">
        <table className="min-w-full divide-y divide-gray-200">
          <thead className="bg-gray-50">
            <tr>
              <th onClick={() => handleSort("studentCode")} className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider cursor-pointer">
                Student code {sortConfig.key === "studentCode" && (sortConfig.direction === "ascending" ? "▲" : "▼")}
              </th>
              <th onClick={() => handleSort("userName")} className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider cursor-pointer">
                Username {sortConfig.key === "userName" && (sortConfig.direction === "ascending" ? "▲" : "▼")}
              </th>
              <th onClick={() => handleSort("firstName")} className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider cursor-pointer">
                First name {sortConfig.key === "firstName" && (sortConfig.direction === "ascending" ? "▲" : "▼")}
              </th>
              <th onClick={() => handleSort("lastName")} className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider cursor-pointer">
                Last name {sortConfig.key === "lastName" && (sortConfig.direction === "ascending" ? "▲" : "▼")}
              </th>
              <th onClick={() => handleSort("email")} className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider cursor-pointer">
                Email {sortConfig.key === "email" && (sortConfig.direction === "ascending" ? "▲" : "▼")}
              </th>
              <th className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider">Action</th>
            </tr>
          </thead>
          <tbody className="bg-white divide-y divide-gray-200">
            {users.length > 0 ? (
              users.map((user, index) => (
                <tr key={index} className={index % 2 === 0 ? 'bg-gray-50' : 'bg-white'}>
                  <td className="px-6 py-4 whitespace-nowrap text-sm text-gray-500">{user.studentCode}</td>
                  <td className="px-6 py-4 whitespace-nowrap text-sm text-gray-900">{user.userName}</td>
                  <td className="px-6 py-4 whitespace-nowrap text-sm text-gray-900">{user.firstName}</td>
                  <td className="px-6 py-4 whitespace-nowrap text-sm text-gray-900">{user.lastName}</td>
                  <td className="px-6 py-4 whitespace-nowrap text-sm text-gray-900">{user.email}</td>
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
                <td colSpan={6} className="px-6 py-4 whitespace-nowrap text-sm text-gray-500 text-center">
                  No result
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