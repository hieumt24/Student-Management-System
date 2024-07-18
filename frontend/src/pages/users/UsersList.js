import React, { useEffect, useState } from "react";
import { Pagination } from "../../components/Pagination";
import { getPaginatedUsers } from "../../services/usersServices";

export const UsersList = () => {
  const [users, setUsers] = useState([]);
  const [pagination, setPagination] = useState({
    pageIndex: 1,
    pageCount: 0,
    pageSize: 10,
    totalRecords: 0,
  });

  useEffect(() => {
    const fetchUsers = () => {
      getPaginatedUsers({
        PageIndex: pagination.pageIndex,
        PageSize: pagination.pageSize,
        search: searchQuery,
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
    fetchUsers();
  }, [pagination.pageIndex, pagination.pageSize, searchQuery]);

  return (
    <div className="px-[112px] w-full py-4">
      <table className="w-full border border-collapse">
        <thead>
          <tr className="border h-10">
            <th className="border">Student code</th>
            <th className="border">Username</th>
            <th className="border">First name</th>
            <th className="border">Last name</th>
            <th className="border">Email</th>
            <th className="border">Action</th>
          </tr>
        </thead>
        <tbody>
          {users.length > 0 ? (
            users.map((user) => (
              <tr>
                <td className="text-center">{user.studentCode}</td>
                <td className="pl-4">{user.userName}</td>
                <td className="pl-4">{user.firstName}</td>
                <td className="pl-4">{user.lastName}</td>
                <td className="pl-4">{user.email}</td>
                <td className="text-center">Buttons</td>
              </tr>
            ))
          ) : (
            <tr>
              <td colSpan={6} className="text-center h-12">
                No result
              </td>
            </tr>
          )}
        </tbody>
      </table>
      <Pagination
        {...pagination}
        setPage={(page) => {
          setPagination({ ...pagination, pageIndex: page });
        }}
      />
    </div>
  );
};
