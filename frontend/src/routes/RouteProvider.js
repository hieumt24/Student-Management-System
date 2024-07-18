import { Route, Routes } from "react-router-dom";
import Login from "../pages/auth/Login";
import NotFound from "../pages/NotFound";
import LandingPage from "../pages/LandingPage";


export const RouteProvider = () => {
    return (
        <Routes>
            <Route path="/auth">
                <Route path="login" element={<Login />} />
            </Route>
            {/* <Route path="/">

            </Route> */}
            <Route path="/*" element={<NotFound />} />
            <Route path="/landing-page" element={<LandingPage />} />
        </Routes>
    );
}