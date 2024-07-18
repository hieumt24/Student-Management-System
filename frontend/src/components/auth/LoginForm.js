import { EyeIcon, EyeSlashIcon } from '@heroicons/react/24/outline';
import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import { toast } from 'react-toastify';
import { login } from '../../services/authServices';

export default function LoginForm() {
    const navigation = useNavigate();
    const [usernameOrEmail, setUsernameOrEmail] = useState('');
    const [password, setPassword] = useState('');
    const [formData, setFormData] = useState({
        usernameOrEmail: "",
        password: ""
    })
    const [showPassword, setShowPassword] = useState(false);

    const togglePasswordVisibility = () => {
        setShowPassword(!showPassword);
    };

    const handleSubmit = async (e) => {
        e.preventDefault();
        login(formData).then((response) => {
            if (response.data.success) {
                toast.success('Successfully logged in!');
                navigation("/landing-page");
            } else {
                toast.error(response.data.message || "Login failed. Please check your credentials.");
            }
            
        }).catch((err) => {
            toast.error(err.message || "Login failed. Check the console for error.")
            console.log(err);
        });
    };

    return (
        <div className="max-w-md w-full space-y-8 p-10 bg-white rounded-xl shadow-lg">
            <div className="text-center">
                <img
                    className="mx-auto h-12 w-auto"
                    src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTjtlp4lj3cznWcQAKEfkSBxPcSO0ZebCdJvA&s"
                    alt="FPT logo"
                />
                <h2 className="mt-6 text-3xl font-extrabold text-gray-900">
                    Sign in to your account
                </h2>
            </div>
            <div className="max-w-md mx-auto mt-8 p-6 bg-white rounded-lg shadow-md">
                <form onSubmit={handleSubmit}>
                    <div className="mb-4">
                        <label htmlFor="usernameOrEmail" className="block text-sm font-medium text-gray-700 mb-1">
                            Username or Email
                        </label>
                        <input
                            type="text"
                            id="usernameOrEmail"
                            className="w-full px-3 py-2 border rounded-md border-gray-300"
                            value={formData.usernameOrEmail}
                            onChange={(e) => setFormData({...formData, usernameOrEmail: e.target.value})}
                            required
                        />
                    </div>
                    <div className="mb-4 relative">
                        <label htmlFor="password" className="block text-sm font-medium text-gray-700 mb-1">
                            Password
                        </label>
                        <input
                            type={showPassword ? "text" : "password"}
                            id="password"
                            className="w-full px-3 py-2 border border-gray-300 rounded-md pr-10"
                            value={formData.password}
                            onChange={(e) => setFormData({...formData, password: e.target.value})}
                            required
                        />
                        <button
                            type="button"
                            className="absolute inset-y-0 right-0 pr-3 flex items-center top-6"
                            onClick={togglePasswordVisibility}
                        >
                            {showPassword ? (
                                <EyeSlashIcon className="h-5 w-5 text-gray-400" />
                            ) : (
                                <EyeIcon className="h-5 w-5 text-gray-400" />
                            )}
                        </button>
                    </div>
                    <button
                        type="submit"
                        className="w-full bg-green-500 text-white py-2 px-4 rounded-md hover:bg-blue-600 transition duration-300"
                    >
                        Login
                    </button>
                </form>
            </div>
        </div>
    );
}