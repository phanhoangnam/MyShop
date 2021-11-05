import React, { Component, Fragment, useState, useEffect } from 'react';
import {useNavigate} from 'react-router-dom';

function Login(props) {
    const [username, setUsername] = useState("");
    const [password, setPassword] = useState("");
    const [rememberMe, setRememberMe] = useState(false);

    const navigate = useNavigate();
    useEffect(() => {
        if (localStorage.getItem('user-info')){
            navigate("/")
        }
    }, [])

    async function login(){
        console.warn("data", username, password, rememberMe)
        let item={username,password,rememberMe};
        let result = await fetch('https://localhost:5000/api/users/login', {
            method: 'POST',
            headers: {
                "Content-Type": "application/json",
                "Accept": "application/json",
            },
            body: JSON.stringify(item)
        });
        result = await result.json();
        localStorage.setItem('user-info', JSON.stringify(result))
        navigate("/")
    }
        return (
            <Fragment>
                <div class="bg-page py-5">
                    <div class="container">
                        {/* <!-- main-heading --> */}
                        <h2 class="main-title-w3layouts mb-2 text-center text-white">Login</h2>
                        {/* <!--// main-heading --> */}
                        <div class="form-body-w3-agile text-center w-lg-50 w-sm-75 w-100 mx-auto mt-5" style={{width:"450px", textAlign: "left"}}>
                            {/* <form onSubmit={login}> */}
                                <div class="form-group">
                                    <label>Username</label>
                                    <input 
                                    type="text" style={{textAlign:"left"}} class="form-control" 
                                    placeholder="Enter username" required=""
                                    onChange={(e)=>setUsername(e.target.value)} />
                                </div>
                                <div class="form-group">
                                    <label>Password</label>
                                    <input 
                                    type="password" style={{textAlign:"left"}} class="form-control" 
                                    placeholder="Password" required="" 
                                    onChange={(e)=>setPassword(e.target.value)} />
                                </div>
                                <div class="d-sm-flex justify-content-between">
                                    <div class="form-check col-md-6 text-sm-left text-center">
                                        <input 
                                        type="checkbox" class="form-check-input" id="exampleCheck1"
                                        onChange={(e)=>setRememberMe(e.target.value)} />
                                        <label class="form-check-label" for="exampleCheck1">Remember me</label>
                                    </div>
                                    <div class="forgot col-md-6 text-sm-right text-center">
                                        <a href="forgot.html">Forgot password?</a>
                                    </div>
                                </div>
                                <button onClick={login} class="btn btn-primary error-w3l-btn mt-sm-5 mt-3 px-4">Login</button>
                            {/* </form> */}
                        </div>

                        {/* <!-- Copyright --> */}
                        <div class="copyright-w3layouts py-xl-3 py-2 mt-xl-5 mt-4 text-center">
                            <p>© 2018 Modernize . All Rights Reserved | Design by
                                <a href="http://w3layouts.com/"> W3layouts </a>
                            </p>
                        </div>
                        {/* <!--// Copyright --> */}
                    </div>
                </div>
            </Fragment>
        )
    
}

export default Login
