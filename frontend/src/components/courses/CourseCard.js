import { toast } from "react-toastify";
import { useAuth } from "../../hooks";
import { enrollCourse } from "../../services";

export const CourseCard = ({ course, enroll = false, enrolled = false }) => {
  const courseStateColors = {
    0: "bg-gray-200",
    1: "bg-green-200",
    2: "bg-blue-200",
    3: "bg-yellow-200",
    4: "bg-red-200",
  };

  const courseStateNames = {
    0: "Not Started",
    1: "Open",
    2: "Complete",
    3: "In Progress",
    4: "Cancelled",
  };

  const {user} = useAuth();

  const handleEnroll = () => {
    console.log(course);
    enrollCourse({
        studentId: user.id,
        courseId: course.id,
        location: user.location
    }).then((response)=>{
        if (response.data.succeeded) {
            toast.success("Enroll successfully");
        } else {
            toast.error(response.data.message);
        }
    }).catch((err)=>{
        console.log(err);
        toast.error(err || "Unexpected error");
    })
  };

  return (
    <div className="bg-white rounded-lg shadow-md overflow-hidden hover:shadow-lg transition duration-300">
      <img
        src={course.imageUrl}
        alt={course.title}
        className="w-full h-48 object-cover"
      />
      <div className="p-4">
        <h2 className="text-xl font-semibold text-gray-800 mb-2">
          {course.title}
        </h2>
        <p className="text-gray-600 mb-2">Course Code: {course.courseCode}</p>
        <p className="text-gray-600 mb-2">Credits: {course.credits}</p>
        <p className="text-gray-600 mb-2">
          Student Joined: {course.studentInCourse}
        </p>
        <p className="text-gray-600">Max Students: {course.maxStudent}</p>

        <div className="w-full flex justify-between mt-2">
          <p
            className={`${
              courseStateColors[course.courseState]
            } font-bold mt-2`}
          >
            State Course: {courseStateNames[course.courseState]}
          </p>
          {enroll && (
            <button
              className={`px-4 py-2 text-white ${enrolled ? "bg-green-300" : "bg-green-500"} rounded-md `}
              onClick={handleEnroll}
              disabled={enrolled}
            >
              {enrolled ? "Enrolled" : "Enroll"}
            </button>
          )}
        </div>
      </div>
    </div>
  );
};
