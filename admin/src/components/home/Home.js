import React, { Component } from 'react';
import { Link } from "react-router-dom";

class Home extends Component {
    render() {
        return (
            <React.Fragment>
                <div className="se-pre-con"></div>
                <div className="wrapper">
                    {/* <!-- Sidebar Holder --> */}
                    <nav id="sidebar">
                        <div className="sidebar-header">
                            <h1>
                                <a href="index.html">Modernize</a>
                            </h1>
                            <span>M</span>
                        </div>
                        <div className="profile-bg"></div>
                        <ul className="list-unstyled components">
                            <li className="active">
                                <a href="index.html">
                                    <i className="fas fa-th-large"></i>
                                    Dashboard
                                </a>
                            </li>
                            <li>
                                <a href="#homeSubmenu" data-toggle="collapse" aria-expanded="false">
                                    <i className="fas fa-laptop"></i>
                                    Components
                                    <i className="fas fa-angle-down fa-pull-right"></i>
                                </a>
                                <ul className="collapse list-unstyled" id="homeSubmenu">
                                    <li>
                                        <a href="cards.html">Cards</a>
                                    </li>
                                    <li>
                                        <a href="carousels.html">Carousels</a>
                                    </li>
                                    <li>
                                        <a href="forms.html">Forms</a>
                                    </li>
                                    <li>
                                        <a href="modals.html">Modals</a>
                                    </li>
                                    <li>
                                        <a href="tables.html">Tables</a>
                                    </li>
                                </ul>
                            </li>
                            <li>
                                <a href="charts.html">
                                    <i className="fas fa-chart-pie"></i>
                                    Charts
                                </a>
                            </li>
                            <li>
                                <a href="grids.html">
                                    <i className="fas fa-th"></i>
                                    Grid Layouts
                                </a>
                            </li>
                            <li>
                                <a href="#pageSubmenu1" data-toggle="collapse" aria-expanded="false">
                                    <i className="far fa-file"></i>
                                    Pages
                                    <i className="fas fa-angle-down fa-pull-right"></i>
                                </a>
                                <ul className="collapse list-unstyled" id="pageSubmenu1">
                                    <li>
                                        <a href="404.html">404</a>
                                    </li>
                                    <li>
                                        <a href="500.html">500</a>
                                    </li>
                                    <li>
                                        <a href="blank.html">Blank</a>
                                    </li>
                                </ul>
                            </li>
                            <li>
                                <a href="mailbox.html">
                                    <i className="far fa-envelope"></i>
                                    Mailbox
                                    <span className="badge badge-secondary float-md-right bg-danger">5 New</span>
                                </a>
                            </li>
                            <li>
                                <a href="widgets.html">
                                    <i className="far fa-window-restore"></i>
                                    Widgets
                                </a>
                            </li>
                            <li>
                                <a href="pricing.html">
                                    <i className="fas fa-table"></i>
                                    Pricing Tables
                                </a>
                            </li>
                            <li>
                                <a href="#pageSubmenu3" data-toggle="collapse" aria-expanded="false">
                                    <i className="fas fa-users"></i>
                                    User
                                    <i className="fas fa-angle-down fa-pull-right"></i>
                                </a>
                                <ul className="collapse list-unstyled" id="pageSubmenu3">
                                    <li>
                                        <Link to={'/login'}>Login</Link>
                                        {/* <a href="/login">Login</a> */}
                                    </li>
                                    <li>
                                        <a href="register.html">Register</a>
                                    </li>
                                    <li>
                                        <a href="forgot.html">Forgot password</a>
                                    </li>
                                </ul>
                            </li>
                            <li>
                                <a href="maps.html">
                                    <i className="far fa-map"></i>
                                    Maps
                                </a>
                            </li>
                        </ul>
                    </nav>

                    {/* <!-- Page Content Holder --> */}
                    <div id="content">
                        {/* <!-- top-bar --> */}
                        <nav className="navbar navbar-default mb-xl-5 mb-4">
                            <div className="container-fluid">

                                <div className="navbar-header">
                                    <button type="button" id="sidebarCollapse" className="btn btn-info navbar-btn">
                                        <i className="fas fa-bars"></i>
                                    </button>
                                </div>
                                {/* <!-- Search-from --> */}
                                <form action="#" method="post" className="form-inline mx-auto search-form">
                                    <input className="form-control mr-sm-2" type="search" placeholder="Search" aria-label="Search" required="" />
                                    <button className="btn btn-style my-2 my-sm-0" type="submit">Search</button>
                                </form>
                                {/* <!--// Search-from --> */}
                                <ul className="top-icons-agileits-w3layouts float-right">
                                    <li className="nav-item dropdown">
                                        <a className="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true"
                                            aria-expanded="false">
                                            <i className="far fa-bell"></i>
                                            <span className="badge">4</span>
                                        </a>
                                        <div className="dropdown-menu top-grid-scroll drop-1">
                                            <h3 className="sub-title-w3-agileits">User notifications</h3>
                                            <a href="#" className="dropdown-item mt-3">
                                                <div className="notif-img-agileinfo">
                                                    <img src="images/clone.jpg" className="img-fluid" alt="Responsive image" />
                                                </div>
                                                <div className="notif-content-wthree">
                                                    <p className="paragraph-agileits-w3layouts py-2">
                                                        <span className="text-diff">John Doe</span> Curabitur non nulla sit amet nisl tempus convallis quis ac lectus.</p>
                                                    <h6>4 mins ago</h6>
                                                </div>
                                            </a>
                                            <a href="#" className="dropdown-item mt-3">
                                                <div className="notif-img-agileinfo">
                                                    <img src="images/clone.jpg" className="img-fluid" alt="Responsive image" />
                                                </div>
                                                <div className="notif-content-wthree">
                                                    <p className="paragraph-agileits-w3layouts py-2">
                                                        <span className="text-diff">Diana</span> Curabitur non nulla sit amet nisl tempus convallis quis ac lectus.</p>
                                                    <h6>6 mins ago</h6>
                                                </div>
                                            </a>
                                            <a href="#" className="dropdown-item mt-3">
                                                <div className="notif-img-agileinfo">
                                                    <img src="images/clone.jpg" className="img-fluid" alt="Responsive image" />
                                                </div>
                                                <div className="notif-content-wthree">
                                                    <p className="paragraph-agileits-w3layouts py-2">
                                                        <span className="text-diff">Steffie</span> Curabitur non nulla sit amet nisl tempus convallis quis ac lectus.</p>
                                                    <h6>12 mins ago</h6>
                                                </div>
                                            </a>
                                            <a href="#" className="dropdown-item mt-3">
                                                <div className="notif-img-agileinfo">
                                                    <img src="images/clone.jpg" className="img-fluid" alt="Responsive image" />
                                                </div>
                                                <div className="notif-content-wthree">
                                                    <p className="paragraph-agileits-w3layouts py-2">
                                                        <span className="text-diff">Jack</span> Curabitur non nulla sit amet nisl tempus convallis quis ac lectus.</p>
                                                    <h6>1 days ago</h6>
                                                </div>
                                            </a>
                                            <div className="dropdown-divider"></div>
                                            <a className="dropdown-item" href="#">view all notifications</a>
                                        </div>
                                    </li>
                                    <li className="nav-item dropdown mx-3">
                                        <a className="nav-link dropdown-toggle" href="#" id="navbarDropdown1" role="button" data-toggle="dropdown" aria-haspopup="true"
                                            aria-expanded="false">
                                            <i className="fas fa-spinner"></i>
                                        </a>
                                        <div className="dropdown-menu top-grid-scroll drop-2">
                                            <h3 className="sub-title-w3-agileits">Shortcuts</h3>
                                            <a href="#" className="dropdown-item mt-3">
                                                <h4>
                                                    <i className="fas fa-chart-pie mr-3"></i>Sed feugiat</h4>
                                            </a>
                                            <a href="#" className="dropdown-item mt-3">
                                                <h4>
                                                    <i className="fab fa-connectdevelop mr-3"></i>Aliquam sed</h4>
                                            </a>
                                            <a href="#" className="dropdown-item mt-3">
                                                <h4>
                                                    <i className="fas fa-tasks mr-3"></i>Lorem ipsum</h4>
                                            </a>
                                            <a href="#" className="dropdown-item mt-3">
                                                <h4>
                                                    <i className="fab fa-superpowers mr-3"></i>Cras rutrum</h4>
                                            </a>
                                        </div>
                                    </li>
                                    <li className="nav-item dropdown">
                                        <a className="nav-link dropdown-toggle" href="#" id="navbarDropdown2" role="button" data-toggle="dropdown" aria-haspopup="true"
                                            aria-expanded="false">
                                            <i className="far fa-user"></i>
                                        </a>
                                        <div className="dropdown-menu drop-3">
                                            <div className="profile d-flex mr-o">
                                                <div className="profile-l align-self-center">
                                                    <img src="images/profile.jpg" className="img-fluid mb-3" alt="Responsive image" />
                                                </div>
                                                <div className="profile-r align-self-center">
                                                    <h3 id="user-infor" className="sub-title-w3-agileits">Will Smith</h3>
                                                    <a href="mailto:info@example.com">info@example.com</a>
                                                </div>
                                            </div>
                                            <a href="#" className="dropdown-item mt-3">
                                                <h4>
                                                    <i className="far fa-user mr-3"></i>My Profile</h4>
                                            </a>
                                            <a href="#" className="dropdown-item mt-3">
                                                <h4>
                                                    <i className="fas fa-link mr-3"></i>Activity</h4>
                                            </a>
                                            <a href="#" className="dropdown-item mt-3">
                                                <h4>
                                                    <i className="far fa-envelope mr-3"></i>Messages</h4>
                                            </a>
                                            <a href="#" className="dropdown-item mt-3">
                                                <h4>
                                                    <i className="far fa-question-circle mr-3"></i>Faq</h4>
                                            </a>
                                            <a href="#" className="dropdown-item mt-3">
                                                <h4>
                                                    <i className="far fa-thumbs-up mr-3"></i>Support</h4>
                                            </a>
                                            <div className="dropdown-divider"></div>
                                            <a className="dropdown-item" href="/login">Logout</a>
                                        </div>
                                    </li>
                                </ul>
                            </div>
                        </nav>
                        {/* <!--// top-bar --> */}
                        <div className="container-fluid">
                            <div className="row">
                                {/* <!-- Stats --> */}
                                <div className="outer-w3-agile col-xl">
                                    <div className="stat-grid p-3 d-flex align-items-center justify-content-between bg-primary">
                                        <div className="s-l">
                                            <h5>Projects</h5>
                                            <p className="paragraph-agileits-w3layouts text-white">Lorem Ipsum</p>
                                        </div>
                                        <div className="s-r">
                                            <h6>340
                                                <i className="far fa-edit"></i>
                                            </h6>
                                        </div>
                                    </div>
                                    <div className="stat-grid p-3 mt-3 d-flex align-items-center justify-content-between bg-success">
                                        <div className="s-l">
                                            <h5>Clients</h5>
                                            <p className="paragraph-agileits-w3layouts">Lorem Ipsum</p>
                                        </div>
                                        <div className="s-r">
                                            <h6>250
                                                <i className="far fa-smile"></i>
                                            </h6>
                                        </div>
                                    </div>
                                    <div className="stat-grid p-3 mt-3 d-flex align-items-center justify-content-between bg-danger">
                                        <div className="s-l">
                                            <h5>Tasks</h5>
                                            <p className="paragraph-agileits-w3layouts">Lorem Ipsum</p>
                                        </div>
                                        <div className="s-r">
                                            <h6>232
                                                <i className="fas fa-tasks"></i>
                                            </h6>
                                        </div>
                                    </div>
                                    <div className="stat-grid p-3 mt-3 d-flex align-items-center justify-content-between bg-warning">
                                        <div className="s-l">
                                            <h5>Employees</h5>
                                            <p className="paragraph-agileits-w3layouts">Lorem Ipsum</p>
                                        </div>
                                        <div className="s-r">
                                            <h6>190
                                                <i className="fas fa-users"></i>
                                            </h6>
                                        </div>
                                    </div>
                                </div>
                                {/* <!--// Stats --> */}
                                {/* <!-- Pie-chart --> */}
                                <div className="outer-w3-agile col-xl ml-xl-3 mt-xl-0 mt-3">
                                    <h4 className="tittle-w3-agileits mb-4">Pie Chart</h4>
                                    <div id="chartdiv"></div>
                                </div>
                                {/* <!--// Pie-chart --> */}
                            </div>
                        </div>
                        {/* <!-- Simple-chart --> */}
                        <div className="outer-w3-agile mt-3">
                            <h4 className="tittle-w3-agileits mb-4">Graph</h4>
                            <div id="Hybridgraph" className="simple-chart1">
                            </div>
                        </div>
                        {/* <!--// Simple-chart --> */}

                        {/* <!--// Bar-Chart --> */}
                        <div className="outer-w3-agile mt-3">
                            <h4 className="tittle-w3-agileits mb-4">Bar Chart</h4>
                            <div id="chart-1"></div>
                        </div>
                        {/* <!--// Bar-Chart --> */}

                        {/* <!--// three-grids --> */}
                        <div className="container-fluid">
                            <div className="row">
                                {/* <!-- Calender --> */}
                                <div className="outer-w3-agile col-xl mt-3">
                                    <h4 className="tittle-w3-agileits mb-4">Multi range Calender</h4>
                                    <div className="multi-select-calender"></div>
                                    <div className="box"></div>
                                </div>
                                {/* <!--// Calender --> */}
                                {/* <!-- Profile --> */}
                                <div className="outer-w3-agile col-xl mt-3 mx-xl-3 p-xl-0 px-md-5">
                                    <div className="header">
                                        <div className="text">
                                            <img src="images/profile.jpg" className="img-fluid rounded-circle" alt="Responsive image" />
                                            <h2>Matthew Scott</h2>
                                            <a href="mailto:info@example.com">
                                                <p>@Lorem ipsum</p>
                                            </a>
                                        </div>
                                    </div>
                                    <div className="container-flud">
                                        <div className="followers row">
                                            <div className="f-left col">
                                                <a href="#">
                                                    <i className="far fa-comments"></i>
                                                </a>
                                            </div>
                                            <div className="f-left col border-left border-right">
                                                <a href="#">
                                                    <i className="fas fa-eye"></i>
                                                </a>
                                            </div>
                                            <div className="f-left col">
                                                <a href="#">
                                                    <i className="far fa-heart"></i>
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                    <ul className="prof-widgt-content">
                                        <li className="menu">
                                            <ul>
                                                <li className="button">
                                                    <a href="#">
                                                        <i className="fas fa-envelope"></i> Messages
                                                        <span>13</span>
                                                    </a>
                                                </li>
                                                <li className="dropdown">
                                                    <ul className="icon-navigation">
                                                        <li>
                                                            <a href="#">Inbox
                                                                <span className="float-right">[09]</span>
                                                            </a>
                                                        </li>
                                                        <li>
                                                            <a href="#">Outbox
                                                                <span className="float-right">[01]</span>
                                                            </a>
                                                        </li>
                                                        <li>
                                                            <a href="#">Sent messages
                                                                <span className="float-right">[03]</span>
                                                            </a>
                                                        </li>
                                                    </ul>
                                                </li>
                                            </ul>
                                        </li>
                                        <li className="menu">
                                            <ul>
                                                <li className="button">
                                                    <a href="#">
                                                        <i className="fas fa-user"></i> Profile</a>
                                                </li>
                                                <li className="dropdown">
                                                    <ul className="icon-navigation">
                                                        <li>
                                                            <a href="#">Change your pic</a>
                                                        </li>
                                                        <li>
                                                            <a href="#">Change your username</a>
                                                        </li>
                                                        <li>
                                                            <a href="#">About us</a>
                                                        </li>
                                                        <li>
                                                            <a href="#">Contact me</a>
                                                        </li>
                                                    </ul>
                                                </li>
                                            </ul>
                                        </li>
                                    </ul>
                                </div>
                                {/* <!--// Profile --> */}
                                {/* <!-- Browser stats --> */}
                                <div className="outer-w3-agile col-xl mt-3">
                                    <h4 className="tittle-w3-agileits mb-4">Browser Stats</h4>
                                    <div className="stats-info stats-body">
                                        <ul className="list-unstyled">
                                            <li className="pb-3">GoogleChrome
                                                <span className="float-right">85%</span>
                                                <div className="progress progress-striped active progress-right">
                                                    <div className="bar green" style={{width: '85%'}}></div>
                                                </div>
                                            </li>
                                            <li className="py-md-4 py-3">Firefox
                                                <span className="float-right">35%</span>
                                                <div className="progress progress-striped active progress-right">
                                                    <div className="bar yellow" style={{width:'35%'}}></div>
                                                </div>
                                            </li>
                                            <li className="py-md-4 py-3">Internet Explorer
                                                <span className="float-right">78%</span>
                                                <div className="progress progress-striped active progress-right">
                                                    <div className="bar red" style={{width:"78%"}}></div>
                                                </div>
                                            </li>
                                            <li className="py-md-4 py-3">Safari
                                                <span className="float-right">50%</span>
                                                <div className="progress progress-striped active progress-right">
                                                    <div className="bar blue" style={{width:"50%"}}></div>
                                                </div>
                                            </li>
                                            <li className="py-md-4 py-3">Opera
                                                <span className="float-right">80%</span>
                                                <div className="progress progress-striped active progress-right">
                                                    <div className="bar light-blue" style={{width:"80%"}}></div>
                                                </div>
                                            </li>
                                            <li className="last py-md-4 py-3">Others
                                                <span className="float-right">60%</span>
                                                <div className="progress progress-striped active progress-right">
                                                    <div className="bar orange" style={{width:"60%"}}></div>
                                                </div>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                                {/* <!--// Browser stats --> */}
                            </div>
                        </div>
                        {/* <!--// Three-grids --> */}
                        {/* <!-- Countdown --> */}
                        <div className="outer-w3-agile mt-3 outer-w3-agile-bg">
                            <h4 className="tittle-w3-agileits mb-4 text-white">Countdown Timer</h4>
                            <div className="simply-countdown-custom" id="simply-countdown-custom"></div>
                        </div>
                        {/* <!--// Countdown --> */}
                        {/* <!-- Copyright --> */}
                        <div className="copyright-w3layouts py-xl-3 py-2 mt-xl-5 mt-4 text-center">
                            <p>© 2018 Modernize . All Rights Reserved | Design by
                                <a href="http://w3layouts.com/"> W3layouts </a>
                            </p>
                        </div>
                        {/* <!--// Copyright --> */}
                    </div>
                </div>
            </React.Fragment>
        )
    }
}

export default Home
