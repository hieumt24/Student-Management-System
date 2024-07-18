import React, { useState } from 'react';
import { EyeIcon, EyeSlashIcon } from '@heroicons/react/24/outline';

export default function LoginForm() {
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [emailError, setEmailError] = useState('err example');
    const [showPassword, setShowPassword] = useState(false);

    // const validateEmail = (email) => {
    //     const re = /\S+@\S+\.\S+/;
    //     return re.test(email);
    // };

    // const handleEmailChange = (e) => {
    //     setEmail(e.target.value);
    //     if (!validateEmail(e.target.value)) {
    //         setEmailError('Not a valid email address.');
    //     } else {
    //         setEmailError('');
    //     }
    // };

    const togglePasswordVisibility = () => {
        setShowPassword(!showPassword);
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
                <form>
                    <div className="mb-4">
                        <label htmlFor="email" className="block text-sm font-medium text-gray-700 mb-1">
                            Email
                        </label>
                        <input
                            type="email"
                            id="email"
                            className={`w-full px-3 py-2 border rounded-md ${emailError ? 'border-red-500' : 'border-gray-300'}`}
                            value={email}
                        // onChange={handleEmailChange}
                        />
                        {emailError && (
                            <p className="mt-1 text-sm text-red-500">{emailError}</p>
                        )}
                    </div>
                    <div className="mb-4 relative">
                        <label htmlFor="password" className="block text-sm font-medium text-gray-700 mb-1">
                            Password
                        </label>
                        <input
                            type={showPassword ? "text" : "password"}
                            id="password"
                            className="w-full px-3 py-2 border border-gray-300 rounded-md pr-10"
                            value={password}
                            onChange={(e) => setPassword(e.target.value)}
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