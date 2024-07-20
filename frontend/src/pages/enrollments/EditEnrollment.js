import React, { useState, useEffect } from "react";
import { useParams, useNavigate } from "react-router-dom";
import { toast } from "react-toastify";
import { MdGrade } from "react-icons/md";
import {
  getEnrollmentById,
  updateEnrollment,
} from "../../services/enrollmentsService";

export const EditEnrollment = () => {
  const { enrollmentId } = useParams();
  const [formData, setFormData] = useState({
    grade: "",
  });
  const [errors, setErrors] = useState({});
  const navigate = useNavigate();

  useEffect(() => {
    const fetchEnrollment = async () => {
      try {
        const response = await getEnrollmentById(enrollmentId);
        const enrollment = response.data.data;
        console.log(enrollment);
        setFormData({
          grade: enrollment.grade,
        });
      } catch (error) {
        toast.error("Error fetching enrollment details");
      }
    };

    fetchEnrollment();
  }, [enrollmentId]);

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData((prevState) => ({
      ...prevState,
      [name]: value,
    }));
  };

  const validateForm = () => {
    let tempErrors = {};
    if (formData.grade === "") {
      tempErrors.grade = "Grade is required";
    } else if (
      isNaN(formData.grade) ||
      formData.grade < 0 ||
      formData.grade > 10
    ) {
      tempErrors.grade = "Grade must be a number between 0 and 10";
    }
    setErrors(tempErrors);
    return Object.keys(tempErrors).length === 0;
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    if (validateForm()) {
      try {
        await updateEnrollment(enrollmentId, {
          grade: formData.grade,
        });
        toast.success("Enrollment updated successfully");
        navigate("/enrollments");
      } catch (error) {
        toast.error("Error updating enrollment");
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
            Edit Enrollment
          </h2>
          <div className="mb-6">
            <label
              className="block text-gray-700 text-sm font-bold mb-2"
              htmlFor="grade"
            >
              Grade
            </label>
            <div className="relative">
              <div className="absolute inset-y-0 left-0 pl-3 flex items-center pointer-events-none">
                <MdGrade className="text-gray-400" />
              </div>
              <input
                className={`shadow appearance-none border rounded w-full py-2 px-3 pl-10 text-gray-700 leading-tight focus:outline-none focus:shadow-outline ${
                  errors.grade ? "border-red-500" : ""
                }`}
                id="grade"
                type="number"
                placeholder="Enter grade"
                name="grade"
                value={formData.grade}
                onChange={handleChange}
              />
            </div>
            {errors.grade && (
              <p className="text-red-500 text-xs italic mt-1">{errors.grade}</p>
            )}
          </div>
          <div className="flex items-center justify-center">
            <button
              className="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded focus:outline-none focus:shadow-outline transition duration-300 ease-in-out transform hover:-translate-y-1 hover:scale-110"
              type="submit"
            >
              Update Enrollment
            </button>
          </div>
        </form>
      </div>
    </div>
  );
};
