import { Navigate } from "react-router-dom";
import { useAuth } from "../../hooks";

export const AuthRequired = ({children}) => {
    const {isAuthenticated} = useAuth();
    return (
        isAuthenticated ? children : <Navigate to="/auth/login"/>
    );
};