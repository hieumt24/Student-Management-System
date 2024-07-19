import React, { useState } from "react";
import { MdDriveFileRenameOutline } from "react-icons/md";
import { useNavigate } from "react-router-dom";
import { toast } from "react-toastify";
import { useAuth } from "../../hooks";
import { createUser } from "../../services/usersServices";

export const CreateUser = () => {
  const [formData, setFormData] = useState({
    firstName: "",
    lastName: "",
    dateOfBirth: "",
    joinedDate: "",
    gender: 1,
    role: 2,
  });
  const [errors, setErrors] = useState({});
  const { user } = useAuth();

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData((prevState) => ({
      ...prevState,
      [name]: value,
    }));

    console.log(formData);
  };

  const validateForm = () => {
    let tempErrors = {};
    if (formData.firstName.trim() === "") {
      tempErrors.firstName = "First Name is required";
    } else if (
      formData.firstName.trim().length < 4 ||
      formData.firstName.trim().length > 50
    ) {
      tempErrors.firstName = "First Name must be between 4 and 50 characters";
    } else if (formData.firstName.trim().includes(" ")) {
      tempErrors.firstName = "First Name must be one word";
    }
    if (formData.lastName.trim() === "") {
      tempErrors.lastName = "Last Name is required";
    } else if (
      formData.lastName.trim().length < 4 ||
      formData.lastName.trim().length > 50
    ) {
      tempErrors.lastName = "Last Name must be between 4 and 50 characters";
    }
    if (formData.dateOfBirth === "") {
      tempErrors.dateOfBirth = "Date of birth is required";
    } else if (new Date(formData.dateOfBirth).toString() === "Invalid Date") {
      tempErrors.dateOfBirth = "Date of birth is invalid";
    }
    if (formData.joinedDate === "") {
      tempErrors.joinedDate = "Joined Date is required";
    }
    if (!formData.gender) {
      tempErrors.gender = "Gender is required";
    }
    if (!formData.role) {
      tempErrors.role = "Role is required";
    }
    setErrors(tempErrors);
    return Object.keys(tempErrors).length === 0;
  };

  const navigate = useNavigate();

  const handleSubmit = async (e) => {
    e.preventDefault();
    if (validateForm()) {
      try {
        const response = await createUser({ ...formData, location: user.location });
        setFormData({
          firstName: "",
          lastName: "",
          dateOfBirth: "",
          joinedDate: "",
          gender: 1,
          role: 2,
        });
        toast.success("User created");
        navigate("/users");
      } catch (error) {
        toast.error(error.response.data.message);
        console.error("Error creating user:", error);
      }
    }
  };

  return (
    <div className="flex items-center justify-center min-h-screen bg-gray-100">
      <div className="w-full max-w-2xl px-4">
        <form
          onSubmit={handleSubmit}
          className="bg-white shadow-2xl rounded-lg px-8 pt-6 pb-8 mb-4"
        >
          <h2 className="text-2xl font-bold mb-6 text-center text-gray-800">
            Create New User
          </h2>
          <div className="mb-6">
            <label
              className="block text-gray-700 text-sm font-bold mb-2"
              htmlFor="firstName"
            >
              First Name
            </label>
            <div className="relative">
              <div className="absolute inset-y-0 left-0 pl-3 flex items-center pointer-events-none">
                <MdDriveFileRenameOutline className="text-gray-400" />
              </div>
              <input
                className={`shadow appearance-none border rounded w-full py-2 px-3 pl-10 text-gray-700 leading-tight focus:outline-none focus:shadow-outline ${errors.firstName ? "border-red-500" : ""
                  }`}
                id="firstName"
                type="text"
                placeholder="Enter user first name"
                name="firstName"
                value={formData.firstName}
                onChange={handleChange}
              />
            </div>
            {errors.firstName && (
              <p className="text-red-500 text-xs italic mt-1">
                {errors.firstName}
              </p>
            )}
          </div>
          <div className="mb-6">
            <label
              className="block text-gray-700 text-sm font-bold mb-2"
              htmlFor="lastName"
            >
              Last Name
            </label>
            <div className="relative">
              <div className="absolute inset-y-0 left-0 pl-3 flex items-center pointer-events-none">
                <MdDriveFileRenameOutline className="text-gray-400" />
              </div>
              <input
                className={`shadow appearance-none border rounded w-full py-2 px-3 pl-10 text-gray-700 leading-tight focus:outline-none focus:shadow-outline ${errors.lastName ? "border-red-500" : ""
                  }`}
                id="lastName"
                type="text"
                placeholder="Enter user last name"
                name="lastName"
                value={formData.lastName}
                onChange={handleChange}
              />
            </div>
            {errors.lastName && (
              <p className="text-red-500 text-xs italic mt-1">
                {errors.lastName}
              </p>
            )}
          </div>
          <div className="mb-6">
            <label
              className="block text-gray-700 text-sm font-bold mb-2"
              htmlFor="dateOfBirth"
            >
              Date of Birth
            </label>
            <div className="relative">
              <div className="absolute inset-y-0 left-0 pl-3 flex items-center pointer-events-none">
                <MdDriveFileRenameOutline className="text-gray-400" />
              </div>
              <input
                className={`shadow appearance-none border rounded w-full py-2 px-3 pl-10 text-gray-700 leading-tight focus:outline-none focus:shadow-outline ${errors.dateOfBirth ? "border-red-500" : ""
                  }`}
                id="dateOfBirth"
                type="date"
                placeholder="Enter user last name"
                name="dateOfBirth"
                value={formData.dateOfBirth}
                onChange={handleChange}
              />
            </div>
            {errors.dateOfBirth && (
              <p className="text-red-500 text-xs italic mt-1">
                {errors.dateOfBirth}
              </p>
            )}
          </div>
          <div className="mb-6">
            <label
              className="block text-gray-700 text-sm font-bold mb-2"
              htmlFor="joinedDate"
            >
              Joined Date
            </label>
            <div className="relative">
              <div className="absolute inset-y-0 left-0 pl-3 flex items-center pointer-events-none">
                <MdDriveFileRenameOutline className="text-gray-400" />
              </div>
              <input
                className={`shadow appearance-none border rounded w-full py-2 px-3 pl-10 text-gray-700 leading-tight focus:outline-none focus:shadow-outline ${errors.joinedDate ? "border-red-500" : ""
                  }`}
                id="joinedDate"
                type="date"
                placeholder="Enter user last name"
                name="joinedDate"
                value={formData.joinedDate}
                onChange={handleChange}
              />
            </div>
            {errors.joinedDate && (
              <p className="text-red-500 text-xs italic mt-1">
                {errors.joinedDate}
              </p>
            )}
          </div>
          <div className="mb-6">
            <label
              className="block text-gray-700 text-sm font-bold mb-2"
              htmlFor="gender"
            >
              Gender
            </label>
            <div className="relative">
              <div className="flex gap-3">
                <div className="flex gap-1">
                  <input
                    type="radio"
                    name="gender"
                    id="gender-male"
                    value={1}
                    checked={formData.gender === 1}
                    onChange={(e) => {
                      setFormData({ ...formData, gender: parseInt(e.target.value) });
                    }}
                  />
                  <label htmlFor="gender-male">Male</label>
                </div>
                <div className="flex gap-1">
                  <input
                    type="radio"
                    name="gender"
                    id="gender-female"
                    value={2}
                    checked={formData.gender === 2}
                    onChange={(e) => {
                      setFormData({ ...formData, gender: parseInt(e.target.value) });
                    }}
                  />
                  <label htmlFor="gender-female">Female</label>
                </div>
              </div>
            </div>
            {errors.gender && (
              <p className="text-red-500 text-xs italic mt-1">
                {errors.gender}
              </p>
            )}
          </div>
          <div className="mb-6">
            <label
              className="block text-gray-700 text-sm font-bold mb-2"
              htmlFor="role"
            >
              Role
            </label>
            <div className="relative">
              <div className="flex gap-3">
                <div className="flex gap-1">
                  <input
                    type="radio"
                    name="role"
                    id="role-admin"
                    value={1}
                    checked={formData.role === 1}
                    onChange={(e) => {
                      setFormData({ ...formData, role: parseInt(e.target.value) });
                    }}
                  />
                  <label htmlFor="role-admin">Admin</label>
                </div>
                <div className="flex gap-1">
                  <input
                    type="radio"
                    name="role"
                    id="role-student"
                    value={2}
                    checked={formData.role === 2}
                    onChange={(e) => {
                      setFormData({ ...formData, role: parseInt(e.target.value) });
                    }}
                  />
                  <label htmlFor="role-student">Student</label>
                </div>
              </div>
            </div>
            {errors.role && (
              <p className="text-red-500 text-xs italic mt-1">
                {errors.role}
              </p>
            )}
          </div>
          <div className="flex items-center justify-center">
            <button
              className="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded focus:outline-none focus:shadow-outline transition duration-300 ease-in-out transform hover:-translate-y-1 hover:scale-110"
              type="submit"
            >
              Create user
            </button>
          </div>
        </form>
      </div>
    </div>
  );
};
