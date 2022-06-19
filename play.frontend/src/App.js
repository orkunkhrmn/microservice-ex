import React, { Component } from "react";
import { Route, Routes } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { BrowserRouter } from 'react-router-dom';

import './App.css';
import { Catalog } from "./components/Catalog";

export default class App extends Component
{
  static displayName = App.name;

  render()
  {
    return (
      <BrowserRouter>
        {/* <Layout>
          <Routes>
            <Route exact path='/' component={Home} />
            <Route exact path='/Home' component={Home} />
          </Routes>
        </Layout> */}
        <Routes>
          <Route path="/" element={<Layout />}>
            <Route index element={<Home />} />
            <Route path="catalog" element={<Catalog />} />
          </Route>
        </Routes>
      </BrowserRouter>
    )
  }
}