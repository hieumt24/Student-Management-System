import React, { useState, useEffect } from "react";
import { useParams, useNavigate } from "react-router-dom";
import { toast } from "react-toastify";
import { MdDriveFileRenameOutline } from "react-icons/md";
import { getUserById, updateUser } from "../../services/usersServices";

export const EditUser = () => {
  const { userId } = useParams();
  const [formData, setFormData] = useState({
    firstName: "",
    lastName: "",
    dateOfBirth: "",
    joinedDate: "",
    gender: 2,
    role: 2,
  });
  const [errors, setErrors] = useState({});
  const navigate = useNavigate();

  useEffect(() => {
    const fetchUser = async () => {
      try {
        const response = await getUserById(userId);
        const user = response.data.data;
        console.log(user);
        setFormData({
          firstName: user.firstName,
          lastName: user.lastName,
          dateOfBirth: user.dateOfBirth.split("T")[0],
          joinedDate: user.joinedDate.split("T")[0],
          gender: user.gender,
          role: user.role,
        });
      } catch (error) {
        toast.error("Error fetching user details");
      }
    };

    fetchUser();
  }, [userId]);

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData((prevState) => ({
      ...prevState,
      [name]: value,
    }));
  };

  const validateForm = () => {
    let tempErrors = {};
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
    setErrors(tempErrors);
    return Object.keys(tempErrors).length === 0;
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    if (validateForm()) {
      try {
        await updateUser(userId, {
          dateOfBirth: formData.dateOfBirth,
          joinedDate: formData.joinedDate,
          gender: formData.gender,
        });
        toast.success("User updated successfully");
        navigate("/users");
      } catch (error) {
        toast.error("Error updating user");
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
            Edit User
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
                className="shadow appearance-none border rounded w-full py-2 px-3 pl-10 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
                id="firstName"
                type="text"
                placeholder="Enter user first name"
                name="firstName"
                value={formData.firstName}
                onChange={handleChange}
                disabled
              />
            </div>
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
                className="shadow appearance-none border rounded w-full py-2 px-3 pl-10 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
                id="lastName"
                type="text"
                placeholder="Enter user last name"
                name="lastName"
                value={formData.lastName}
                onChange={handleChange}
                disabled
              />
            </div>
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
                className={`shadow appearance-none border rounded w-full py-2 px-3 pl-10 text-gray-700 leading-tight focus:outline-none focus:shadow-outline ${
                  errors.dateOfBirth ? "border-red-500" : ""
                }`}
                id="dateOfBirth"
                type="date"
                placeholder="Enter user date of birth"
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
                className={`shadow appearance-none border rounded w-full py-2 px-3 pl-10 text-gray-700 leading-tight focus:outline-none focus:shadow-outline ${
                  errors.joinedDate ? "border-red-500" : ""
                }`}
                id="joinedDate"
                type="date"
                placeholder="Enter user joined date"
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
                      setFormData({
                        ...formData,
                        gender: parseInt(e.target.value),
                      });
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
                      setFormData({
                        ...formData,
                        gender: parseInt(e.target.value),
                      });
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
          <div className="flex items-center justify-center">
            <button
              className="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded focus:outline-none focus:shadow-outline transition duration-300 ease-in-out transform hover:-translate-y-1 hover:scale-110"
              type="submit"
            >
              Update user
            </button>
          </div>
        </form>
      </div>
    </div>
  );
};
