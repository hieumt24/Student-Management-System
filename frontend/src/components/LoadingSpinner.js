export const LoadingSpinner = () => {
  return (
    <div className="fixed inset-0 z-50 flex items-center justify-center bg-white bg-opacity-30">
      <div className="h-28 w-28 animate-spin rounded-full border-b-4 border-t-4 border-blue-500"></div>
    </div>
  );
};
