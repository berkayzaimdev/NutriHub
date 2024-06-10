import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Products from "./pages/Products";
import Users from "./pages/Users";
import Categories from "./pages/Categories/Categories";
import Orders from "./pages/Orders";
import Sidebar from "./components/Sidebar/Sidebar";
import Brands from "./pages/Brands/Brands";
import Coupons from "./pages/Coupons/Coupons";
import MainContent from "./pages/MainContent/MainContent";
import Dashboard from "./pages/Dashboard/Dashboard";

function App() {
  return (
    <Router>
      <div>
        <Sidebar />
        <Routes>
          <Route
            path="/"
            element={
              <MainContent>
                <Dashboard />
              </MainContent>
            }
          />
          <Route
            path="/urunler"
            element={
              <MainContent>
                <Products />
              </MainContent>
            }
          />
          <Route
            path="/kategoriler"
            element={
              <MainContent>
                <Categories />
              </MainContent>
            }
          />
          <Route
            path="/markalar"
            element={
              <MainContent>
                <Brands />
              </MainContent>
            }
          />
          <Route
            path="/kuponlar"
            element={
              <MainContent>
                <Coupons />
              </MainContent>
            }
          />
          <Route
            path="/kullanicilar"
            element={
              <MainContent>
                <Users />
              </MainContent>
            }
          />
          <Route
            path="/siparisler"
            element={
              <MainContent>
                <Orders />
              </MainContent>
            }
          />
        </Routes>
      </div>
    </Router>
  );
}

export default App;
