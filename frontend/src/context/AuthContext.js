import { jwtDecode } from "jwt-decode";
import React, { createContext, useEffect, useState } from "react";

export const AuthContext = createContext({
  token: null,
  isAuthenticated: false,
  setIsAuthenticated: () => {},
  user: {
    id: "",
    username: "",
    role: "Student",
    location: 1
  },
  setUser: () => {},
  loading: true
});

export const AuthProvider = ({ children }) => {
  const [loading, setLoading] = useState(true);
  const [token, setToken] = useState(localStorage.getItem("token"));
  const [user, setUser] = useState({
    id: "",
    username: "",
    role: "Student",
    location: 1,
  });
  const [isAuthenticated, setIsAuthenticated] = useState(!!token);
  const fetchUserFromToken = () => {
    setLoading(true);
    const storedToken = localStorage.getItem("token");

    if (storedToken) {
      setIsAuthenticated(true);
      setToken(storedToken);
      const decodedToken = jwtDecode(storedToken);
      setUser({
        id: decodedToken.UserId,
        username:
          decodedToken[
            "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"
          ],
        role: decodedToken[
          "http://schemas.microsoft.com/ws/2008/06/identity/claims/role"
        ],
        location: parseInt(decodedToken.Location)
      });
    } else {
      setUser({
        id: "",
        username: "",
        role: "Student",
        location: 1
      });
      setIsAuthenticated(false);
    }
    setLoading(false);
  };

  useEffect(() => {
    fetchUserFromToken();
  }, [token, isAuthenticated]);
  
  const value = {
    user,
    setUser,
    isAuthenticated,
    setIsAuthenticated,
    loading
  };

  return <AuthContext.Provider value={value}>{children}</AuthContext.Provider>;
};