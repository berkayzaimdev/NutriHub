import React from "react";

function Dashboard() {
  return (
    <div class="wrapper d-flex flex-column min-vh-100">
      <div class="body flex-grow-1">
        <div class="container-lg px-4">
          <div class="row mb-4">
            <div class="col-xl-5 col-xxl-4 mb-4 mb-xl-0">
              <script
                id="_carbonads_js"
                async=""
                type="text/javascript"
                src="//cdn.carbonads.com/carbon.js?serve=CEAICKJY&amp;placement=coreuiio"
              ></script>
            </div>
          </div>
          <div class="row g-4 mb-4">
            <div class="col-sm-6 col-xl-3">
              <div class="card text-white bg-primary">
                <div class="card-body pb-0 d-flex justify-content-between align-items-start">
                  <div>
                    <div class="fs-4 fw-semibold">
                      26K <span class="fs-6 fw-normal">(-12.4% )</span>
                    </div>
                    <div>Users</div>
                  </div>
                  <div class="dropdown">
                    <button
                      class="btn btn-transparent text-white p-0"
                      type="button"
                      data-coreui-toggle="dropdown"
                      aria-haspopup="true"
                      aria-expanded="false"
                    ></button>
                    <div class="dropdown-menu dropdown-menu-end">
                      <a class="dropdown-item" href="#">
                        Action
                      </a>
                      <a class="dropdown-item" href="#">
                        Another action
                      </a>
                      <a class="dropdown-item" href="#">
                        Something else here
                      </a>
                    </div>
                  </div>
                </div>
                <div class="c-chart-wrapper mt-3 mx-3">
                  <canvas class="chart" id="card-chart1" height="70"></canvas>
                </div>
              </div>
            </div>
            <div class="col-sm-6 col-xl-3">
              <div class="card text-white bg-info">
                <div class="card-body pb-0 d-flex justify-content-between align-items-start">
                  <div>
                    <div class="fs-4 fw-semibold">
                      $6.200 <span class="fs-6 fw-normal">(40.9% )</span>
                    </div>
                    <div>Income</div>
                  </div>
                  <div class="dropdown">
                    <button
                      class="btn btn-transparent text-white p-0"
                      type="button"
                      data-coreui-toggle="dropdown"
                      aria-haspopup="true"
                      aria-expanded="false"
                    ></button>
                    <div class="dropdown-menu dropdown-menu-end">
                      <a class="dropdown-item" href="#">
                        Action
                      </a>
                      <a class="dropdown-item" href="#">
                        Another action
                      </a>
                      <a class="dropdown-item" href="#">
                        Something else here
                      </a>
                    </div>
                  </div>
                </div>
                <div class="c-chart-wrapper mt-3 mx-3">
                  <canvas class="chart" id="card-chart2" height="70"></canvas>
                </div>
              </div>
            </div>
            <div class="col-sm-6 col-xl-3">
              <div class="card text-white bg-warning">
                <div class="card-body pb-0 d-flex justify-content-between align-items-start">
                  <div>
                    <div class="fs-4 fw-semibold">
                      2.49% <span class="fs-6 fw-normal">(84.7% )</span>
                    </div>
                    <div>Conversion Rate</div>
                  </div>
                  <div class="dropdown">
                    <button
                      class="btn btn-transparent text-white p-0"
                      type="button"
                      data-coreui-toggle="dropdown"
                      aria-haspopup="true"
                      aria-expanded="false"
                    >
                      <svg class="icon"></svg>
                    </button>
                    <div class="dropdown-menu dropdown-menu-end">
                      <a class="dropdown-item" href="#">
                        Action
                      </a>
                      <a class="dropdown-item" href="#">
                        Another action
                      </a>
                      <a class="dropdown-item" href="#">
                        Something else here
                      </a>
                    </div>
                  </div>
                </div>
                <div class="c-chart-wrapper mt-3">
                  <canvas class="chart" id="card-chart3" height="70"></canvas>
                </div>
              </div>
            </div>
            <div class="col-sm-6 col-xl-3">
              <div class="card text-white bg-danger">
                <div class="card-body pb-0 d-flex justify-content-between align-items-start">
                  <div>
                    <div class="fs-4 fw-semibold">
                      44K{" "}
                      <span class="fs-6 fw-normal">
                        (-23.6%
                        <svg class="icon"></svg>)
                      </span>
                    </div>
                    <div>Sessions</div>
                  </div>
                  <div class="dropdown">
                    <button
                      class="btn btn-transparent text-white p-0"
                      type="button"
                      data-coreui-toggle="dropdown"
                      aria-haspopup="true"
                      aria-expanded="false"
                    >
                      <svg class="icon"></svg>
                    </button>
                    <div class="dropdown-menu dropdown-menu-end">
                      <a class="dropdown-item" href="#">
                        Action
                      </a>
                      <a class="dropdown-item" href="#">
                        Another action
                      </a>
                      <a class="dropdown-item" href="#">
                        Something else here
                      </a>
                    </div>
                  </div>
                </div>
                <div class="c-chart-wrapper mt-3 mx-3">
                  <canvas class="chart" id="card-chart4" height="70"></canvas>
                </div>
              </div>
            </div>
          </div>
          <div class="card mb-4">
            <div class="card-body">
              <div class="d-flex justify-content-between">
                <div>
                  <h4 class="card-title mb-0">Traffic</h4>
                  <div class="small text-body-secondary">
                    January - July 2023
                  </div>
                </div>
                <div
                  class="btn-toolbar d-none d-md-block"
                  role="toolbar"
                  aria-label="Toolbar with buttons"
                >
                  <div
                    class="btn-group btn-group-toggle mx-3"
                    data-coreui-toggle="buttons"
                  >
                    <input
                      class="btn-check"
                      id="option1"
                      type="radio"
                      name="options"
                      autocomplete="off"
                    />
                    <label class="btn btn-outline-secondary"> Day</label>
                    <input
                      class="btn-check"
                      id="option2"
                      type="radio"
                      name="options"
                      autocomplete="off"
                      checked=""
                    />
                    <label class="btn btn-outline-secondary active">
                      {" "}
                      Month
                    </label>
                    <input
                      class="btn-check"
                      id="option3"
                      type="radio"
                      name="options"
                      autocomplete="off"
                    />
                    <label class="btn btn-outline-secondary"> Year</label>
                  </div>
                  <button class="btn btn-primary" type="button">
                    <svg class="icon"></svg>
                  </button>
                </div>
              </div>
              <div class="c-chart-wrapper">
                <canvas class="chart" id="main-chart" height="300"></canvas>
              </div>
            </div>
            <div class="card-footer">
              <div class="row row-cols-1 row-cols-sm-2 row-cols-lg-4 row-cols-xl-5 g-4 mb-2 text-center">
                <div class="col">
                  <div class="text-body-secondary">Visits</div>
                  <div class="fw-semibold text-truncate">
                    29.703 Users (40%)
                  </div>
                  <div class="progress progress-thin mt-2">
                    <div
                      class="progress-bar bg-success"
                      role="progressbar"
                      aria-valuenow="40"
                      aria-valuemin="0"
                      aria-valuemax="100"
                    ></div>
                  </div>
                </div>
                <div class="col">
                  <div class="text-body-secondary">Unique</div>
                  <div class="fw-semibold text-truncate">
                    24.093 Users (20%)
                  </div>
                  <div class="progress progress-thin mt-2">
                    <div
                      class="progress-bar bg-info"
                      role="progressbar"
                      aria-valuenow="20"
                      aria-valuemin="0"
                      aria-valuemax="100"
                    ></div>
                  </div>
                </div>
                <div class="col">
                  <div class="text-body-secondary">Pageviews</div>
                  <div class="fw-semibold text-truncate">
                    78.706 Views (60%)
                  </div>
                  <div class="progress progress-thin mt-2">
                    <div
                      class="progress-bar bg-warning"
                      role="progressbar"
                      aria-valuenow="60"
                      aria-valuemin="0"
                      aria-valuemax="100"
                    ></div>
                  </div>
                </div>
                <div class="col">
                  <div class="text-body-secondary">New Users</div>
                  <div class="fw-semibold text-truncate">
                    22.123 Users (80%)
                  </div>
                  <div class="progress progress-thin mt-2">
                    <div
                      class="progress-bar bg-danger"
                      role="progressbar"
                      aria-valuenow="80"
                      aria-valuemin="0"
                      aria-valuemax="100"
                    ></div>
                  </div>
                </div>
                <div class="col d-none d-xl-block">
                  <div class="text-body-secondary">Bounce Rate</div>
                  <div class="fw-semibold text-truncate">40.15%</div>
                  <div class="progress progress-thin mt-2">
                    <div
                      class="progress-bar"
                      role="progressbar"
                      aria-valuenow="40"
                      aria-valuemin="0"
                      aria-valuemax="100"
                    ></div>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div class="row g-4 mb-4">
            <div class="col-sm-6 col-lg-4">
              <div class="card">
                <div class="card-header position-relative d-flex justify-content-center align-items-center">
                  <svg class="icon icon-3xl text-white my-4"></svg>
                  <div class="chart-wrapper position-absolute top-0 start-0 w-100 h-100">
                    <canvas id="social-box-chart-1" height="90"></canvas>
                  </div>
                </div>
                <div class="card-body row text-center">
                  <div class="col">
                    <div class="fs-5 fw-semibold">89k</div>
                    <div class="text-uppercase text-body-secondary small">
                      friends
                    </div>
                  </div>
                  <div class="vr"></div>
                  <div class="col">
                    <div class="fs-5 fw-semibold">459</div>
                    <div class="text-uppercase text-body-secondary small">
                      feeds
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div class="col-sm-6 col-lg-4">
              <div class="card">
                <div class="card-header position-relative d-flex justify-content-center align-items-center">
                  <svg class="icon icon-3xl text-white my-4"></svg>
                  <div class="chart-wrapper position-absolute top-0 start-0 w-100 h-100">
                    <canvas id="social-box-chart-2" height="90"></canvas>
                  </div>
                </div>
                <div class="card-body row text-center">
                  <div class="col">
                    <div class="fs-5 fw-semibold">973k</div>
                    <div class="text-uppercase text-body-secondary small">
                      followers
                    </div>
                  </div>
                  <div class="vr"></div>
                  <div class="col">
                    <div class="fs-5 fw-semibold">1.792</div>
                    <div class="text-uppercase text-body-secondary small">
                      tweets
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div class="col-sm-6 col-lg-4">
              <div class="card">
                <div class="card-header position-relative d-flex justify-content-center align-items-center">
                  <svg class="icon icon-3xl text-white my-4"></svg>
                  <div class="chart-wrapper position-absolute top-0 start-0 w-100 h-100">
                    <canvas id="social-box-chart-3" height="90"></canvas>
                  </div>
                </div>
                <div class="card-body row text-center">
                  <div class="col">
                    <div class="fs-5 fw-semibold">500+</div>
                    <div class="text-uppercase text-body-secondary small">
                      contacts
                    </div>
                  </div>
                  <div class="vr"></div>
                  <div class="col">
                    <div class="fs-5 fw-semibold">292</div>
                    <div class="text-uppercase text-body-secondary small">
                      feeds
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div class="row">
            <div class="col-md-12">
              <div class="card mb-4">
                <div class="card-header">Traffic &amp; Sales</div>
                <div class="card-body">
                  <div class="row">
                    <div class="col-sm-6">
                      <div class="row">
                        <div class="col-6">
                          <div class="border-start border-start-4 border-start-info px-3 mb-3">
                            <div class="small text-body-secondary text-truncate">
                              New Clients
                            </div>
                            <div class="fs-5 fw-semibold">9.123</div>
                          </div>
                        </div>
                        <div class="col-6">
                          <div class="border-start border-start-4 border-start-danger px-3 mb-3">
                            <div class="small text-body-secondary text-truncate">
                              Recuring Clients
                            </div>
                            <div class="fs-5 fw-semibold">22.643</div>
                          </div>
                        </div>
                      </div>
                      <hr class="mt-0" />
                      <div class="progress-group mb-4">
                        <div class="progress-group-prepend">
                          <span class="text-body-secondary small">Monday</span>
                        </div>
                        <div class="progress-group-bars">
                          <div class="progress progress-thin">
                            <div
                              class="progress-bar bg-info"
                              role="progressbar"
                              aria-valuenow="34"
                              aria-valuemin="0"
                              aria-valuemax="100"
                            ></div>
                          </div>
                          <div class="progress progress-thin">
                            <div
                              class="progress-bar bg-danger"
                              role="progressbar"
                              aria-valuenow="78"
                              aria-valuemin="0"
                              aria-valuemax="100"
                            ></div>
                          </div>
                        </div>
                      </div>
                      <div class="progress-group mb-4">
                        <div class="progress-group-prepend">
                          <span class="text-body-secondary small">Tuesday</span>
                        </div>
                        <div class="progress-group-bars">
                          <div class="progress progress-thin">
                            <div
                              class="progress-bar bg-info"
                              role="progressbar"
                              aria-valuenow="56"
                              aria-valuemin="0"
                              aria-valuemax="100"
                            ></div>
                          </div>
                          <div class="progress progress-thin">
                            <div
                              class="progress-bar bg-danger"
                              role="progressbar"
                              aria-valuenow="94"
                              aria-valuemin="0"
                              aria-valuemax="100"
                            ></div>
                          </div>
                        </div>
                      </div>
                      <div class="progress-group mb-4">
                        <div class="progress-group-prepend">
                          <span class="text-body-secondary small">
                            Wednesday
                          </span>
                        </div>
                        <div class="progress-group-bars">
                          <div class="progress progress-thin">
                            <div
                              class="progress-bar bg-info"
                              role="progressbar"
                              aria-valuenow="12"
                              aria-valuemin="0"
                              aria-valuemax="100"
                            ></div>
                          </div>
                          <div class="progress progress-thin">
                            <div
                              class="progress-bar bg-danger"
                              role="progressbar"
                              aria-valuenow="67"
                              aria-valuemin="0"
                              aria-valuemax="100"
                            ></div>
                          </div>
                        </div>
                      </div>
                      <div class="progress-group mb-4">
                        <div class="progress-group-prepend">
                          <span class="text-body-secondary small">
                            Thursday
                          </span>
                        </div>
                        <div class="progress-group-bars">
                          <div class="progress progress-thin">
                            <div
                              class="progress-bar bg-info"
                              role="progressbar"
                              aria-valuenow="43"
                              aria-valuemin="0"
                              aria-valuemax="100"
                            ></div>
                          </div>
                          <div class="progress progress-thin">
                            <div
                              class="progress-bar bg-danger"
                              role="progressbar"
                              aria-valuenow="91"
                              aria-valuemin="0"
                              aria-valuemax="100"
                            ></div>
                          </div>
                        </div>
                      </div>
                      <div class="progress-group mb-4">
                        <div class="progress-group-prepend">
                          <span class="text-body-secondary small">Friday</span>
                        </div>
                        <div class="progress-group-bars">
                          <div class="progress progress-thin">
                            <div
                              class="progress-bar bg-info"
                              role="progressbar"
                              aria-valuenow="22"
                              aria-valuemin="0"
                              aria-valuemax="100"
                            ></div>
                          </div>
                          <div class="progress progress-thin">
                            <div
                              class="progress-bar bg-danger"
                              role="progressbar"
                              aria-valuenow="73"
                              aria-valuemin="0"
                              aria-valuemax="100"
                            ></div>
                          </div>
                        </div>
                      </div>
                      <div class="progress-group mb-4">
                        <div class="progress-group-prepend">
                          <span class="text-body-secondary small">
                            Saturday
                          </span>
                        </div>
                        <div class="progress-group-bars">
                          <div class="progress progress-thin">
                            <div
                              class="progress-bar bg-info"
                              role="progressbar"
                              aria-valuenow="53"
                              aria-valuemin="0"
                              aria-valuemax="100"
                            ></div>
                          </div>
                          <div class="progress progress-thin">
                            <div
                              class="progress-bar bg-danger"
                              role="progressbar"
                              aria-valuenow="82"
                              aria-valuemin="0"
                              aria-valuemax="100"
                            ></div>
                          </div>
                        </div>
                      </div>
                      <div class="progress-group mb-4">
                        <div class="progress-group-prepend">
                          <span class="text-body-secondary small">Sunday</span>
                        </div>
                        <div class="progress-group-bars">
                          <div class="progress progress-thin">
                            <div
                              class="progress-bar bg-info"
                              role="progressbar"
                              aria-valuenow="9"
                              aria-valuemin="0"
                              aria-valuemax="100"
                            ></div>
                          </div>
                          <div class="progress progress-thin">
                            <div
                              class="progress-bar bg-danger"
                              role="progressbar"
                              aria-valuenow="69"
                              aria-valuemin="0"
                              aria-valuemax="100"
                            ></div>
                          </div>
                        </div>
                      </div>
                    </div>

                    <div class="col-sm-6">
                      <div class="row">
                        <div class="col-6">
                          <div class="border-start border-start-4 border-start-warning px-3 mb-3">
                            <div class="small text-body-secondary text-truncate">
                              Pageviews
                            </div>
                            <div class="fs-5 fw-semibold">78.623</div>
                          </div>
                        </div>
                        <div class="col-6">
                          <div class="border-start border-start-4 border-start-success px-3 mb-3">
                            <div class="small text-body-secondary text-truncate">
                              Organic
                            </div>
                            <div class="fs-5 fw-semibold">49.123</div>
                          </div>
                        </div>
                      </div>
                      <hr class="mt-0" />
                      <div class="progress-group">
                        <div class="progress-group-header">
                          <svg class="icon icon-lg me-2"></svg>
                          <div>Male</div>
                          <div class="ms-auto fw-semibold">43%</div>
                        </div>
                        <div class="progress-group-bars">
                          <div class="progress progress-thin">
                            <div
                              class="progress-bar bg-warning"
                              role="progressbar"
                              aria-valuenow="43"
                              aria-valuemin="0"
                              aria-valuemax="100"
                            ></div>
                          </div>
                        </div>
                      </div>
                      <div class="progress-group mb-5">
                        <div class="progress-group-header">
                          <svg class="icon icon-lg me-2"></svg>
                          <div>Female</div>
                          <div class="ms-auto fw-semibold">37%</div>
                        </div>
                        <div class="progress-group-bars">
                          <div class="progress progress-thin">
                            <div
                              class="progress-bar bg-warning"
                              role="progressbar"
                              aria-valuenow="43"
                              aria-valuemin="0"
                              aria-valuemax="100"
                            ></div>
                          </div>
                        </div>
                      </div>
                      <div class="progress-group">
                        <div class="progress-group-header">
                          <svg class="icon icon-lg me-2"></svg>
                          <div>Organic Search</div>
                          <div class="ms-auto fw-semibold me-2">191.235</div>
                          <div class="text-body-secondary small">(56%)</div>
                        </div>
                        <div class="progress-group-bars">
                          <div class="progress progress-thin">
                            <div
                              class="progress-bar bg-success"
                              role="progressbar"
                              aria-valuenow="56"
                              aria-valuemin="0"
                              aria-valuemax="100"
                            ></div>
                          </div>
                        </div>
                      </div>
                      <div class="progress-group">
                        <div class="progress-group-header">
                          <svg class="icon icon-lg me-2"></svg>
                          <div>Facebook</div>
                          <div class="ms-auto fw-semibold me-2">51.223</div>
                          <div class="text-body-secondary small">(15%)</div>
                        </div>
                        <div class="progress-group-bars">
                          <div class="progress progress-thin">
                            <div
                              class="progress-bar bg-success"
                              role="progressbar"
                              aria-valuenow="15"
                              aria-valuemin="0"
                              aria-valuemax="100"
                            ></div>
                          </div>
                        </div>
                      </div>
                      <div class="progress-group">
                        <div class="progress-group-header">
                          <svg class="icon icon-lg me-2"></svg>
                          <div>Twitter</div>
                          <div class="ms-auto fw-semibold me-2">37.564</div>
                          <div class="text-body-secondary small">(11%)</div>
                        </div>
                        <div class="progress-group-bars">
                          <div class="progress progress-thin">
                            <div
                              class="progress-bar bg-success"
                              role="progressbar"
                              aria-valuenow="11"
                              aria-valuemin="0"
                              aria-valuemax="100"
                            ></div>
                          </div>
                        </div>
                      </div>
                      <div class="progress-group">
                        <div class="progress-group-header">
                          <svg class="icon icon-lg me-2"></svg>
                          <div>LinkedIn</div>
                          <div class="ms-auto fw-semibold me-2">27.319</div>
                          <div class="text-body-secondary small">(8%)</div>
                        </div>
                        <div class="progress-group-bars">
                          <div class="progress progress-thin">
                            <div
                              class="progress-bar bg-success"
                              role="progressbar"
                              aria-valuenow="8"
                              aria-valuemin="0"
                              aria-valuemax="100"
                            ></div>
                          </div>
                        </div>
                      </div>
                    </div>
                  </div>
                  <br />
                  <div class="table-responsive">
                    <table class="table border mb-0">
                      <thead class="fw-semibold text-nowrap">
                        <tr class="align-middle">
                          <th class="bg-body-secondary text-center">
                            <svg class="icon"></svg>
                          </th>
                          <th class="bg-body-secondary">User</th>
                          <th class="bg-body-secondary text-center">Country</th>
                          <th class="bg-body-secondary">Usage</th>
                          <th class="bg-body-secondary text-center">
                            Payment Method
                          </th>
                          <th class="bg-body-secondary">Activity</th>
                          <th class="bg-body-secondary"></th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr class="align-middle">
                          <td class="text-center">
                            <div class="avatar avatar-md">
                              <img
                                class="avatar-img"
                                src="assets/img/avatars/1.jpg"
                                alt="user@email.com"
                              />
                              <span class="avatar-status bg-success"></span>
                            </div>
                          </td>
                          <td>
                            <div class="text-nowrap">Yiorgos Avraamu</div>
                            <div class="small text-body-secondary text-nowrap">
                              <span>New</span> | Registered: Jan 1, 2023
                            </div>
                          </td>
                          <td class="text-center">
                            <svg class="icon icon-xl"></svg>
                          </td>
                          <td>
                            <div class="d-flex justify-content-between align-items-baseline">
                              <div class="fw-semibold">50%</div>
                              <div class="text-nowrap small text-body-secondary ms-3">
                                Jun 11, 2023 - Jul 10, 2023
                              </div>
                            </div>
                            <div class="progress progress-thin">
                              <div
                                class="progress-bar bg-success"
                                role="progressbar"
                                aria-valuenow="50"
                                aria-valuemin="0"
                                aria-valuemax="100"
                              ></div>
                            </div>
                          </td>
                          <td class="text-center">
                            <svg class="icon icon-xl"></svg>
                          </td>
                          <td>
                            <div class="small text-body-secondary">
                              Last login
                            </div>
                            <div class="fw-semibold text-nowrap">
                              10 sec ago
                            </div>
                          </td>
                          <td>
                            <div class="dropdown">
                              <button
                                class="btn btn-transparent p-0"
                                type="button"
                                data-coreui-toggle="dropdown"
                                aria-haspopup="true"
                                aria-expanded="false"
                              >
                                <svg class="icon"></svg>
                              </button>
                              <div class="dropdown-menu dropdown-menu-end">
                                <a class="dropdown-item" href="#">
                                  Info
                                </a>
                                <a class="dropdown-item" href="#">
                                  Edit
                                </a>
                                <a class="dropdown-item text-danger" href="#">
                                  Delete
                                </a>
                              </div>
                            </div>
                          </td>
                        </tr>
                        <tr class="align-middle">
                          <td class="text-center">
                            <div class="avatar avatar-md">
                              <img
                                class="avatar-img"
                                src="assets/img/avatars/2.jpg"
                                alt="user@email.com"
                              />
                              <span class="avatar-status bg-danger"></span>
                            </div>
                          </td>
                          <td>
                            <div class="text-nowrap">Avram Tarasios</div>
                            <div class="small text-body-secondary text-nowrap">
                              <span>Recurring</span> | Registered: Jan 1, 2023
                            </div>
                          </td>
                          <td class="text-center">
                            <svg class="icon icon-xl"></svg>
                          </td>
                          <td>
                            <div class="d-flex justify-content-between align-items-baseline">
                              <div class="fw-semibold">10%</div>
                              <div class="text-nowrap small text-body-secondary ms-3">
                                Jun 11, 2023 - Jul 10, 2023
                              </div>
                            </div>
                            <div class="progress progress-thin">
                              <div
                                class="progress-bar bg-info"
                                role="progressbar"
                                aria-valuenow="10"
                                aria-valuemin="0"
                                aria-valuemax="100"
                              ></div>
                            </div>
                          </td>
                          <td class="text-center">
                            <svg class="icon icon-xl"></svg>
                          </td>
                          <td>
                            <div class="small text-body-secondary">
                              Last login
                            </div>
                            <div class="fw-semibold text-nowrap">
                              5 minutes ago
                            </div>
                          </td>
                          <td>
                            <div class="dropdown">
                              <button
                                class="btn btn-transparent p-0"
                                type="button"
                                data-coreui-toggle="dropdown"
                                aria-haspopup="true"
                                aria-expanded="false"
                              >
                                <svg class="icon"></svg>
                              </button>
                              <div class="dropdown-menu dropdown-menu-end">
                                <a class="dropdown-item" href="#">
                                  Info
                                </a>
                                <a class="dropdown-item" href="#">
                                  Edit
                                </a>
                                <a class="dropdown-item text-danger" href="#">
                                  Delete
                                </a>
                              </div>
                            </div>
                          </td>
                        </tr>
                        <tr class="align-middle">
                          <td class="text-center">
                            <div class="avatar avatar-md">
                              <img
                                class="avatar-img"
                                src="assets/img/avatars/3.jpg"
                                alt="user@email.com"
                              />
                              <span class="avatar-status bg-warning"></span>
                            </div>
                          </td>
                          <td>
                            <div class="text-nowrap">Quintin Ed</div>
                            <div class="small text-body-secondary text-nowrap">
                              <span>New</span> | Registered: Jan 1, 2023
                            </div>
                          </td>
                          <td class="text-center">
                            <svg class="icon icon-xl"></svg>
                          </td>
                          <td>
                            <div class="d-flex justify-content-between align-items-baseline">
                              <div class="fw-semibold">74%</div>
                              <div class="text-nowrap small text-body-secondary ms-3">
                                Jun 11, 2023 - Jul 10, 2023
                              </div>
                            </div>
                            <div class="progress progress-thin">
                              <div
                                class="progress-bar bg-warning"
                                role="progressbar"
                                aria-valuenow="74"
                                aria-valuemin="0"
                                aria-valuemax="100"
                              ></div>
                            </div>
                          </td>
                          <td class="text-center">
                            <svg class="icon icon-xl"></svg>
                          </td>
                          <td>
                            <div class="small text-body-secondary">
                              Last login
                            </div>
                            <div class="fw-semibold text-nowrap">
                              1 hour ago
                            </div>
                          </td>
                          <td>
                            <div class="dropdown">
                              <button
                                class="btn btn-transparent p-0"
                                type="button"
                                data-coreui-toggle="dropdown"
                                aria-haspopup="true"
                                aria-expanded="false"
                              >
                                <svg class="icon"></svg>
                              </button>
                              <div class="dropdown-menu dropdown-menu-end">
                                <a class="dropdown-item" href="#">
                                  Info
                                </a>
                                <a class="dropdown-item" href="#">
                                  Edit
                                </a>
                                <a class="dropdown-item text-danger" href="#">
                                  Delete
                                </a>
                              </div>
                            </div>
                          </td>
                        </tr>
                        <tr class="align-middle">
                          <td class="text-center">
                            <div class="avatar avatar-md">
                              <img
                                class="avatar-img"
                                src="assets/img/avatars/4.jpg"
                                alt="user@email.com"
                              />
                              <span class="avatar-status bg-secondary"></span>
                            </div>
                          </td>
                          <td>
                            <div class="text-nowrap">Enéas Kwadwo</div>
                            <div class="small text-body-secondary text-nowrap">
                              <span>New</span> | Registered: Jan 1, 2023
                            </div>
                          </td>
                          <td class="text-center">
                            <svg class="icon icon-xl"></svg>
                          </td>
                          <td>
                            <div class="d-flex justify-content-between align-items-baseline">
                              <div class="fw-semibold">98%</div>
                              <div class="text-nowrap small text-body-secondary ms-3">
                                Jun 11, 2023 - Jul 10, 2023
                              </div>
                            </div>
                            <div class="progress progress-thin">
                              <div
                                class="progress-bar bg-danger"
                                role="progressbar"
                                aria-valuenow="98"
                                aria-valuemin="0"
                                aria-valuemax="100"
                              ></div>
                            </div>
                          </td>
                          <td class="text-center">
                            <svg class="icon icon-xl"></svg>
                          </td>
                          <td>
                            <div class="small text-body-secondary">
                              Last login
                            </div>
                            <div class="fw-semibold text-nowrap">
                              Last month
                            </div>
                          </td>
                          <td>
                            <div class="dropdown">
                              <button
                                class="btn btn-transparent p-0"
                                type="button"
                                data-coreui-toggle="dropdown"
                                aria-haspopup="true"
                                aria-expanded="false"
                              >
                                <svg class="icon"></svg>
                              </button>
                              <div class="dropdown-menu dropdown-menu-end">
                                <a class="dropdown-item" href="#">
                                  Info
                                </a>
                                <a class="dropdown-item" href="#">
                                  Edit
                                </a>
                                <a class="dropdown-item text-danger" href="#">
                                  Delete
                                </a>
                              </div>
                            </div>
                          </td>
                        </tr>
                        <tr class="align-middle">
                          <td class="text-center">
                            <div class="avatar avatar-md">
                              <img
                                class="avatar-img"
                                src="assets/img/avatars/5.jpg"
                                alt="user@email.com"
                              />
                              <span class="avatar-status bg-success"></span>
                            </div>
                          </td>
                          <td>
                            <div class="text-nowrap">Agapetus Tadeáš</div>
                            <div class="small text-body-secondary text-nowrap">
                              <span>New</span> | Registered: Jan 1, 2023
                            </div>
                          </td>
                          <td class="text-center">
                            <svg class="icon icon-xl"></svg>
                          </td>
                          <td>
                            <div class="d-flex justify-content-between align-items-baseline">
                              <div class="fw-semibold">22%</div>
                              <div class="text-nowrap small text-body-secondary ms-3">
                                Jun 11, 2023 - Jul 10, 2023
                              </div>
                            </div>
                            <div class="progress progress-thin">
                              <div
                                class="progress-bar bg-info"
                                role="progressbar"
                                aria-valuenow="22"
                                aria-valuemin="0"
                                aria-valuemax="100"
                              ></div>
                            </div>
                          </td>
                          <td class="text-center">
                            <svg class="icon icon-xl"></svg>
                          </td>
                          <td>
                            <div class="small text-body-secondary">
                              Last login
                            </div>
                            <div class="fw-semibold text-nowrap">Last week</div>
                          </td>
                          <td>
                            <div class="dropdown dropup">
                              <button
                                class="btn btn-transparent p-0"
                                type="button"
                                data-coreui-toggle="dropdown"
                                aria-haspopup="true"
                                aria-expanded="false"
                              >
                                <svg class="icon"></svg>
                              </button>
                              <div class="dropdown-menu dropdown-menu-end">
                                <a class="dropdown-item" href="#">
                                  Info
                                </a>
                                <a class="dropdown-item" href="#">
                                  Edit
                                </a>
                                <a class="dropdown-item text-danger" href="#">
                                  Delete
                                </a>
                              </div>
                            </div>
                          </td>
                        </tr>
                        <tr class="align-middle">
                          <td class="text-center">
                            <div class="avatar avatar-md">
                              <img
                                class="avatar-img"
                                src="assets/img/avatars/6.jpg"
                                alt="user@email.com"
                              />
                              <span class="avatar-status bg-danger"></span>
                            </div>
                          </td>
                          <td>
                            <div class="text-nowrap">Friderik Dávid</div>
                            <div class="small text-body-secondary text-nowrap">
                              <span>New</span> | Registered: Jan 1, 2023
                            </div>
                          </td>
                          <td class="text-center">
                            <svg class="icon icon-xl"></svg>
                          </td>
                          <td>
                            <div class="d-flex justify-content-between align-items-baseline">
                              <div class="fw-semibold">43%</div>
                              <div class="text-nowrap small text-body-secondary ms-3">
                                Jun 11, 2023 - Jul 10, 2023
                              </div>
                            </div>
                            <div class="progress progress-thin">
                              <div
                                class="progress-bar bg-success"
                                role="progressbar"
                                aria-valuenow="43"
                                aria-valuemin="0"
                                aria-valuemax="100"
                              ></div>
                            </div>
                          </td>
                          <td class="text-center">
                            <svg class="icon icon-xl"></svg>
                          </td>
                          <td>
                            <div class="small text-body-secondary">
                              Last login
                            </div>
                            <div class="fw-semibold text-nowrap">Yesterday</div>
                          </td>
                          <td>
                            <div class="dropdown dropup">
                              <button
                                class="btn btn-transparent p-0"
                                type="button"
                                data-coreui-toggle="dropdown"
                                aria-haspopup="true"
                                aria-expanded="false"
                              >
                                <svg class="icon"></svg>
                              </button>
                              <div class="dropdown-menu dropdown-menu-end">
                                <a class="dropdown-item" href="#">
                                  Info
                                </a>
                                <a class="dropdown-item" href="#">
                                  Edit
                                </a>
                                <a class="dropdown-item text-danger" href="#">
                                  Delete
                                </a>
                              </div>
                            </div>
                          </td>
                        </tr>
                      </tbody>
                    </table>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      <footer class="footer px-4">
        <div>
          <a href="https://coreui.io">CoreUI </a>
          <a href="https://coreui.io/product/free-bootstrap-admin-template/">
            Bootstrap Admin Template
          </a>{" "}
          &copy; 2024 creativeLabs.
        </div>
        <div class="ms-auto">
          Powered by&nbsp;
          <a href="https://coreui.io/docs/">CoreUI UI Components</a>
        </div>
      </footer>
    </div>
  );
}

export default Dashboard;
