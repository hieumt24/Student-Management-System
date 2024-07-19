import React, { useState } from 'react';
import { FaCalendarAlt, FaGraduationCap } from 'react-icons/fa';
import { useNavigate } from 'react-router-dom';
import { toast } from 'react-toastify';
import { createSemester } from '../../services/semestersService';

export const CreateSemester = () => {
    const [formData, setFormData] = useState({
        semesterName: '',
        academicYear: ''
    });
    const [errors, setErrors] = useState({});

    const handleChange = (e) => {
        const { name, value } = e.target;
        setFormData(prevState => ({
            ...prevState,
            [name]: value
        }));
    };

    const validateForm = () => {
        let tempErrors = {};
        if (formData.semesterName.length < 4 || formData.semesterName.length > 50) {
            tempErrors.semesterName = 'Semester Name must be between 4 and 50 characters';
        }
        if (formData.academicYear.length < 4 || formData.academicYear.length > 50) {
            tempErrors.academicYear = 'Academic Year must be between 4 and 50 characters';
        }
        setErrors(tempErrors);
        return Object.keys(tempErrors).length === 0;
    };

    const navigate = useNavigate();

    const handleSubmit = async (e) => {
        e.preventDefault();
        if (validateForm()) {
            try {
                const response = await createSemester(formData);
                console.log('Semester created:', response);
                setFormData({ semesterName: '', academicYear: '' });
                toast.success("Semester created");
                navigate("/semesters");
            } catch (error) {
                toast.error(error.response.data.message);
                console.error('Error creating semester:', error);
            }
        }
    };

    return (
        <div className="flex items-center justify-center min-h-screen bg-gray-100">
            <div className="w-full max-w-2xl px-4">
                <form onSubmit={handleSubmit} className="bg-white shadow-2xl rounded-lg px-8 pt-6 pb-8 mb-4">
                    <h2 className="text-2xl font-bold mb-6 text-center text-gray-800">Create New Semester</h2>
                    <div className="mb-6">
                        <label className="block text-gray-700 text-sm font-bold mb-2" htmlFor="semesterName">
                            Semester Name
                        </label>
                        <div className="relative">
                            <div className="absolute inset-y-0 left-0 pl-3 flex items-center pointer-events-none">
                                <FaGraduationCap className="text-gray-400" />
                            </div>
                            <input
                                className={`shadow appearance-none border rounded w-full py-2 px-3 pl-10 text-gray-700 leading-tight focus:outline-none focus:shadow-outline ${errors.semesterName ? 'border-red-500' : ''}`}
                                id="semesterName"
                                type="text"
                                placeholder="Enter semester name"
                                name="semesterName"
                                value={formData.semesterName}
                                onChange={handleChange}
                            />
                        </div>
                        {errors.semesterName && <p className="text-red-500 text-xs italic mt-1">{errors.semesterName}</p>}
                    </div>
                    <div className="mb-6">
                        <label className="block text-gray-700 text-sm font-bold mb-2" htmlFor="academicYear">
                            Academic Year
                        </label>
                        <div className="relative">
                            <div className="absolute inset-y-0 left-0 pl-3 flex items-center pointer-events-none">
                                <FaCalendarAlt className="text-gray-400" />
                            </div>
                            <input
                                className={`shadow appearance-none border rounded w-full py-2 px-3 pl-10 text-gray-700 leading-tight focus:outline-none focus:shadow-outline ${errors.academicYear ? 'border-red-500' : ''}`}
                                id="academicYear"
                                type="text"
                                placeholder="Enter academic year"
                                name="academicYear"
                                value={formData.academicYear}
                                onChange={handleChange}
                            />
                        </div>
                        {errors.academicYear && <p className="text-red-500 text-xs italic mt-1">{errors.academicYear}</p>}
                    </div>
                    <div className="flex items-center justify-center">
                        <button
                            className="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded focus:outline-none focus:shadow-outline transition duration-300 ease-in-out transform hover:-translate-y-1 hover:scale-110"
                            type="submit"
                        >
                            Create Semester
                        </button>
                    </div>
                </form>
            </div>
        </div>
    );
};