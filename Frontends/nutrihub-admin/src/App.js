import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import CustomNavbar from "./component/CustomNavbar";
import Products from "./pages/Products";
import Users from "./pages/Users";
import Categories from "./pages/Categories";
import Orders from "./pages/Orders";
function App() {
  return (
    <Router>
      <CustomNavbar />
      <Routes>
        <Route path="/urunler" element={<Products></Products>} />
        <Route path="/kullanicilar" element={<Users></Users>} />
        <Route path="/kategoriler" element={<Categories></Categories>} />
        <Route path="/siparisler" element={<Orders></Orders>} />
      </Routes>
    </Router>
  );
}

export default App;
