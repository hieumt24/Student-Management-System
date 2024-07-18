import { MdKeyboardArrowLeft, MdKeyboardArrowRight } from "react-icons/md";

export const Pagination = ({
  pageIndex,
  pageSize,
  pageCount,
  setPage,
  totalRecords = 0,
}) => {
  const getPaginationNumbers = () => {
    const pageNumbers = [];

    if (pageCount <= 7) {
      for (let i = 1; i <= pageCount; i++) {
        pageNumbers.push(i);
      }
    } else {
      pageNumbers.push(1); // Always include the first page

      if (pageIndex > 3) {
        pageNumbers.push("...");
      }

      for (
        let i = Math.max(2, pageIndex - 1);
        i <= Math.min(pageIndex + 1, pageCount - 1);
        i++
      ) {
        pageNumbers.push(i);
      }

      if (pageIndex < pageCount - 2) {
        pageNumbers.push("...");
      }

      pageNumbers.push(pageCount); // Always include the last page
    }

    return pageNumbers;
  };
  return (
    <div className="flex items-center justify-between space-x-2 py-4">
        <div className="flex items-center justify-end space-x-2 flex-grow">
        {totalRecords !== 0 && (
          <div className="text-sm">
            Showing {(pageIndex - 1) * pageSize + 1} -{" "}
            {Math.min(pageIndex * pageSize, totalRecords)} of {totalRecords}{" "}
            records
          </div>
        )}
        {pageCount > 1 && (
          <div className="flex space-x-2 items-center">
            <button
              onClick={() => setPage(--pageIndex)}
              disabled={pageIndex === 1}
              className="px-1"
            >
              <MdKeyboardArrowLeft size={24} />
            </button>
            {getPaginationNumbers().map((page, idx) => (
              <button
                key={idx}
                className={`rounded-md border px-3 py-1 transition-all ${
                  page === pageIndex
                    ? "bg-red-600 text-white"
                    : "border-gray-300"
                } ${typeof page === "number" ? "hover:bg-red-300" : "cursor-default"}`}
                onClick={() => {
                  typeof page === "number" && setPage(page);
                }}
                disabled={typeof page !== "number"}
              >
                {page}
              </button>
            ))}
            <button
              onClick={() => setPage(++pageIndex)}
              disabled={pageIndex === pageCount}
              className="px-1"
            >
              <MdKeyboardArrowRight size={24} />
            </button>
          </div>
        )}
      </div>
    </div>
  )
};
