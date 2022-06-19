import React, { Component } from "react";
import { Container } from 'react-bootstrap';
import { NavMenu } from './NavMenu';
import { Footer } from './Footer';
import { Outlet } from "react-router-dom";

export class Layout extends Component
{
    static displayName = Layout.name;

    render()
    {
        return (
            <div>
                <NavMenu />
                <Container>
                    <Outlet />
                </Container>
                <Footer />
            </div>
        );
    }
}