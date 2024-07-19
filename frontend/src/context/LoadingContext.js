import React, { createContext, useState } from "react";

export const LoadingContext = createContext({
  isLoading: false,
  setIsLoading: () => {},
});

export const LoadingProvider = ({
  children,
}) => {
  const [isLoading, setIsLoading] = useState(false);

  return (
    <LoadingContext.Provider value={{ isLoading, setIsLoading }}>
      {children}
    </LoadingContext.Provider>
  );
};

