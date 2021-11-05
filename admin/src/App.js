import logo from './logo.svg';
import './App.css';
import React from 'react';
// import { BrowserRouter, Switch, Route } from 'react-router-dom';
import Home from './components/home/Home';
import { Fragment } from 'react/cjs/react.production.min';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Login from './components/login/Login';

function App() {
  return (
    <React.Fragment>
      <div className="App">
        <BrowserRouter>
          {/* <Home /> */}
          {/* <Switch>
          <Route exac path="/login">
              <Login/>
            </Route>
          </Switch> */}
          <Routes>
          <Route path='/' element={<Home />}></Route>
          <Route path='/login' element={<Login />}></Route>
        </Routes> 
            
        </BrowserRouter>
      </div>
    </React.Fragment>
  );
}

export default App;
