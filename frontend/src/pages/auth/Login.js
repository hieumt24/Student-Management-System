import React from 'react';
import LoginForm from '../../components/auth/LoginForm';
import backgroundImage from "../../asset/image/background.jpg"

export default function Login() {
    return (
        <div className="min-h-screen flex items-center justify-center bg-cover bg-center" style={{ backgroundImage: `url(${backgroundImage})` }}>
            <LoginForm />
        </div>
    );
}
