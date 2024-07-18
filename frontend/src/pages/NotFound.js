import React from 'react'

export default function NotFound() {
    return (
        <div className="min-h-screen flex items-center justify-center bg-gray-800 " >
            <div className="text-center" >
                <h1 className="text-7xl font-bold text-white mb-8">404</h1>
                <h2 className="text-2xl text-white mb-8">Page Not Found</h2>
                <h3 className=" text-white mb-8">The page you are looking for doesn't exist or an other error occurred</h3>
                <button href="#" className="text-white font-bold bg-purple-500 p-2 rounded-md ">Back to Home</button>
            </div>
        </div>
    )
}