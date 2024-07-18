import { jwtDecode } from "jwt-decode";
import React, { createContext, useContext, useEffect, useState } from "react";

const AuthContext = createContext({
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
});

export const AuthProvider = ({ children }) => {
  const [token, setToken] = useState(localStorage.getItem("token"));
  const [user, setUser] = useState({
    id: "",
    username: "",
    role: "Student",
    location: 1
  });
  const [isAuthenticated, setIsAuthenticated] = useState(!!token);
  const fetchUserFromToken = () => {
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
        location: decodedToken.Location
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
  };

  useEffect(() => {
    fetchUserFromToken();
  }, [token, isAuthenticated]);
  const value = {
    user,
    setUser,
    isAuthenticated,
    setIsAuthenticated
  };

  return <AuthContext.Provider value={value}>{children}</AuthContext.Provider>;
};

export const useAuth = () => {
  const context = useContext(AuthContext);
  if (!context) {
    throw new Error("useAuth must be used within an AuthProvider");
  }
  return context;
};
