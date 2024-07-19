import { Route, Routes } from "react-router-dom";
import { AuthRequired } from "../components/auth";
import { LoadingSpinner } from "../components/LoadingSpinner";
import { useAuth } from "../hooks";
import Login from "../pages/auth/Login";
import { CourseList, CreateCourse } from "../pages/courses";
import LandingPage from "../pages/LandingPage";
import Layout from "../pages/Layout";
import NotFound from "../pages/NotFound";
import { CreateSemester, SemesterList } from "../pages/semester";
import { CreateUser, UsersList } from "../pages/users";

export const RouteProvider = () => {
  const { user, loading } = useAuth();
  if (loading)
    return (
      <div className="w-full h-full flex items-center justify-center">
        <LoadingSpinner />
      </div>
    );
  return (
    <Routes>
      <Route path="/auth">
        <Route path="login" element={<Login />} />
      </Route>
      {user.role === "Admin" ? (
        <>
          <Route
            path="/"
            element={
              <AuthRequired>
                <LandingPage />
              </AuthRequired>
            }
          />
          <Route
            path="/users"
            element={
              <AuthRequired>
                <Layout />
              </AuthRequired>
            }
          >
            <Route path="" element={<UsersList />}></Route>
            <Route path="create" element={<CreateUser />}></Route>
          </Route>
          <Route
            path="/semesters"
            element={
              <AuthRequired>
                <Layout />
              </AuthRequired>
            }
          >
            <Route path="" element={<SemesterList />}></Route>
            <Route path="create" element={<CreateSemester />}></Route>
          </Route>
          <Route
            path="/courses"
            element={
              <AuthRequired>
                <Layout />
              </AuthRequired>
            }
          >
            <Route path="" element={<CourseList />}></Route>
            <Route path="create" element={<CreateCourse />}></Route>
          </Route>
        </>
      ) : (
        <>
          <Route
            path="/"
            element={
              <AuthRequired>
                <LandingPage />
              </AuthRequired>
            }
          />
          <Route
            path="/courses"
            element={
              <AuthRequired>
                <Layout/>
              </AuthRequired>
            }
          >
            <Route path="" element={<CourseList/>}/>
          </Route>
        </>
      )}

      <Route path="/*" element={<NotFound />} />
    </Routes>
  );
};
