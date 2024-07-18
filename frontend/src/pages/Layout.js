import React from 'react'
import { Outlet } from 'react-router-dom'
import HeaderLayout from '../components/layout/HeaderLayout'

export default function Layout() {
    return (
        <>
            <HeaderLayout />
            <Outlet/>
        </>
    )
}
