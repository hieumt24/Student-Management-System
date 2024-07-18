import { Route, Routes } from "react-router-dom";
import Login from "../pages/auth/Login";
import LandingPage from "../pages/LandingPage";
import Layout from "../pages/Layout";
import NotFound from "../pages/NotFound";
import { UsersList } from "../pages/users";

export const RouteProvider = () => {
  return (
    <Routes>
      <Route path="/auth">
        <Route path="login" element={<Login />} />
      </Route>
      <Route path="/" element={<LandingPage />} />
      <Route path="/users" element={<Layout />}>
        <Route path="" element={<UsersList />}></Route>
      </Route>
      <Route path="/*" element={<NotFound />} />
    </Routes>
  );
};
