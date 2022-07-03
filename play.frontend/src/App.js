import React, { Component } from "react";
import { Route, Routes } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { BrowserRouter } from 'react-router-dom';

import './App.css';
import { Catalog } from "./components/Catalog";
import { ApplicationPaths } from "./components/Constants";
import { Inventory } from "./components/Inventory";

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
            <Route path={ApplicationPaths.CatalogPath} element={<Catalog />} />
            <Route path={ApplicationPaths.InventoryPath} element={<Inventory />} />
          </Route>
        </Routes>
      </BrowserRouter>
    )
  }
}