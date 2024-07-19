import React, { useState, useEffect } from "react";
import { useParams, useNavigate } from "react-router-dom";
import { FaBookOpen, FaGraduationCap, FaImage, FaUsers } from "react-icons/fa";
import { toast } from "react-toastify";
import { getCourseById, updateCourse } from "../../services";
import axios from "axios";

const CourseStates = [
  { label: "Not Started", value: 0 },
  { label: "Open", value: 1 },
  { label: "Complete", value: 2 },
  { label: "In Progress", value: 3 },
  { label: "Cancelled", value: 4 },
];

export const EditCourse = () => {
  const { courseId } = useParams();
  const navigate = useNavigate();
  const [formData, setFormData] = useState({
    courseCode: "",
    title: "",
    credits: "",
    maxStudent: "",
    level: "",
    courseState: "",
    imageUrl: "",
  });
  const [file, setFile] = useState(null);
  const [errors, setErrors] = useState({});

  useEffect(() => {
    fetchCourseData();
  }, [courseId]);

  const fetchCourseData = async () => {
    try {
      const response = await getCourseById(courseId);
      setFormData(response.data.data);
    } catch (error) {
      console.error("Error fetching course data:", error);
      toast.error("Failed to fetch course data");
    }
  };

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData((prevState) => ({
      ...prevState,
      [name]:
        name === "level" || name === "courseState" ? Number(value) : value,
    }));
  };

  const handleFileChange = (e) => {
    setFile(e.target.files[0]);
  };

  const validateForm = () => {
    let tempErrors = {};
    if (!formData.courseCode) tempErrors.courseCode = "Course Code is required";
    if (!formData.title) tempErrors.title = "Title is required";
    if (!formData.credits) tempErrors.credits = "Credits are required";
    if (!formData.maxStudent)
      tempErrors.maxStudent = "Max Students is required";
    if (!formData.level) tempErrors.level = "Level is required";
    if (!formData.courseState)
      tempErrors.courseState = "Course State is required";
    setErrors(tempErrors);
    return Object.keys(tempErrors).length === 0;
  };

  const handleSubmit = async (e) => {
    console.log("Form submitted");
    e.preventDefault();
    toast.info("Updating course...");

    if (validateForm()) {
      console.log("Form is valid");
      try {
        let imageUrl = formData.imageUrl;
        if (file) {
          const uploadData = new FormData();
          uploadData.append("File", file);
          uploadData.append("FileName", file.name);
          console.log("Uploading image...");
          const response = await axios.post(
            "http://localhost:5000/api/v1/images/upload",
            uploadData
          );
          imageUrl = response.data.filePath;
          console.log("Image uploaded successfully");
        }
        const finalFormData = { ...formData, imageUrl };
        console.log("Updating course...", finalFormData);
        await updateCourse(courseId, finalFormData);
        console.log("Course updated successfully");
        console.log("Navigating to /courses");
        navigate("/courses");
        toast.success("Course updated successfully.");
      } catch (error) {
        console.error("Error updating course:", error);
        toast.error(error.response?.data?.message || "Error updating course");
      }
    } else {
      console.log("Form is invalid", errors);
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
            Edit Course
          </h2>

          {/* Course Code Input */}
          <div className="mb-4">
            <label
              className="block text-gray-700 text-sm font-bold mb-2"
              htmlFor="courseCode"
            >
              Course Code
            </label>
            <div className="relative">
              <div className="absolute inset-y-0 left-0 pl-3 flex items-center pointer-events-none">
                <FaGraduationCap className="text-gray-400" />
              </div>
              <input
                className={`shadow appearance-none border rounded w-full py-2 px-3 pl-10 text-gray-700 leading-tight focus:outline-none focus:shadow-outline ${
                  errors.courseCode ? "border-red-500" : ""
                }`}
                id="courseCode"
                type="text"
                placeholder="Enter course code"
                name="courseCode"
                value={formData.courseCode}
                onChange={handleChange}
              />
            </div>
            {errors.courseCode && (
              <p className="text-red-500 text-xs italic mt-1">
                {errors.courseCode}
              </p>
            )}
          </div>

          {/* Title Input */}
          <div className="mb-4">
            <label
              className="block text-gray-700 text-sm font-bold mb-2"
              htmlFor="title"
            >
              Title
            </label>
            <div className="relative">
              <div className="absolute inset-y-0 left-0 pl-3 flex items-center pointer-events-none">
                <FaBookOpen className="text-gray-400" />
              </div>
              <input
                className={`shadow appearance-none border rounded w-full py-2 px-3 pl-10 text-gray-700 leading-tight focus:outline-none focus:shadow-outline ${
                  errors.title ? "border-red-500" : ""
                }`}
                id="title"
                type="text"
                placeholder="Enter course title"
                name="title"
                value={formData.title}
                onChange={handleChange}
              />
            </div>
            {errors.title && (
              <p className="text-red-500 text-xs italic mt-1">{errors.title}</p>
            )}
          </div>

          {/* Credits Input */}
          <div className="mb-4">
            <label
              className="block text-gray-700 text-sm font-bold mb-2"
              htmlFor="credits"
            >
              Credits
            </label>
            <input
              className={`shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline ${
                errors.credits ? "border-red-500" : ""
              }`}
              id="credits"
              type="number"
              placeholder="Enter credits"
              name="credits"
              value={formData.credits}
              onChange={handleChange}
            />
            {errors.credits && (
              <p className="text-red-500 text-xs italic mt-1">
                {errors.credits}
              </p>
            )}
          </div>

          {/* Max Students Input */}
          <div className="mb-4">
            <label
              className="block text-gray-700 text-sm font-bold mb-2"
              htmlFor="maxStudent"
            >
              Max Students
            </label>
            <div className="relative">
              <div className="absolute inset-y-0 left-0 pl-3 flex items-center pointer-events-none">
                <FaUsers className="text-gray-400" />
              </div>
              <input
                className={`shadow appearance-none border rounded w-full py-2 px-3 pl-10 text-gray-700 leading-tight focus:outline-none focus:shadow-outline ${
                  errors.maxStudent ? "border-red-500" : ""
                }`}
                id="maxStudent"
                type="number"
                placeholder="Enter max students"
                name="maxStudent"
                value={formData.maxStudent}
                onChange={handleChange}
              />
            </div>
            {errors.maxStudent && (
              <p className="text-red-500 text-xs italic mt-1">
                {errors.maxStudent}
              </p>
            )}
          </div>

          {/* Level Select */}
          <div className="mb-4">
            <label
              className="block text-gray-700 text-sm font-bold mb-2"
              htmlFor="level"
            >
              Level
            </label>
            <select
              className={`shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline ${
                errors.level ? "border-red-500" : ""
              }`}
              id="level"
              name="level"
              value={formData.level}
              onChange={handleChange}
            >
              <option value="" disabled>
                Select level
              </option>
              {[...Array(9)].map((_, index) => (
                <option key={index + 1} value={index + 1}>
                  {index + 1}
                </option>
              ))}
            </select>
            {errors.level && (
              <p className="text-red-500 text-xs italic mt-1">{errors.level}</p>
            )}
          </div>

          {/* Course State Select */}
          <div className="mb-4">
            <label
              className="block text-gray-700 text-sm font-bold mb-2"
              htmlFor="courseState"
            >
              Course State
            </label>
            <select
              className={`shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline ${
                errors.courseState ? "border-red-500" : ""
              }`}
              id="courseState"
              name="courseState"
              value={formData.courseState}
              onChange={handleChange}
            >
              <option value="" disabled>
                Select course state
              </option>
              {CourseStates.map((state) => (
                <option key={state.value} value={state.value}>
                  {state.label}
                </option>
              ))}
            </select>
            {errors.courseState && (
              <p className="text-red-500 text-xs italic mt-1">
                {errors.courseState}
              </p>
            )}
          </div>

          {/* Image Upload */}
          <div className="mb-6">
            <label
              className="block text-gray-700 text-sm font-bold mb-2"
              htmlFor="imageUrl"
            >
              Image
            </label>
            <div className="relative">
              <div className="absolute inset-y-0 left-0 pl-3 flex items-center pointer-events-none">
                <FaImage className="text-gray-400" />
              </div>
              <input
                className="shadow appearance-none border rounded w-full py-2 px-3 pl-10 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
                id="imageUrl"
                type="file"
                name="image"
                onChange={handleFileChange}
              />
            </div>
            {formData.imageUrl && (
              <img
                src={formData.imageUrl}
                alt="Course"
                className="mt-2 w-full h-32 object-cover rounded"
              />
            )}
          </div>

          {/* Submit Button */}
          <div className="flex items-center justify-center">
            <button
              className="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded focus:outline-none focus:shadow-outline transition duration-300 ease-in-out transform hover:-translate-y-1 hover:scale-110"
              type="submit"
            >
              Update Course
            </button>
          </div>
        </form>
      </div>
    </div>
  );
};
