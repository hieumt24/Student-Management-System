import { Route, Routes } from "react-router-dom";
import Login from "../pages/auth/Login";
import LandingPage from "../pages/LandingPage";
import Layout from "../pages/Layout";
import NotFound from "../pages/NotFound";
import { CreateSemester, SemesterList } from "../pages/semester";
import { CreateUser, UsersList } from "../pages/users";
import { CourseList, CreateCourse } from "../pages/courses";


export const RouteProvider = () => {
  return (
    <Routes>
      <Route path="/auth">
        <Route path="login" element={<Login />} />
      </Route>
      <Route path="/" element={<LandingPage />} />
      <Route path="/users" element={<Layout />}>
        <Route path="" element={<UsersList />}></Route>
        <Route path="create" element={<CreateUser />}></Route>
      </Route>
      <Route path="/semesters" element={<Layout />}>
        <Route path="" element={<SemesterList />}></Route>
        <Route path="create" element={<CreateSemester />}></Route>
      </Route>
      <Route path="/courses" element={<Layout />}>
        <Route path="" element={<CourseList />}></Route>
        <Route path="create" element={<CreateCourse />}></Route>
      </Route>
      <Route path="/*" element={<NotFound />} />
    </Routes>
  );
};
