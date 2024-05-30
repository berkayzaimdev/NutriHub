import { BrowserRouter, Route, Routes } from "react-router-dom";
import CustomNavbar from "./navbar/CustomNavbar";
import CustomFooter from "./components/CustomFooter";
import Home from "./pages/Home";
import Product from "./pages/Product";
import Products from "./pages/Products";
import MyProfile from "./pages/MyProfile";
import MyCart from "./pages/MyCart";
import MyFavourites from "./pages/MyFavourites";
import NotFoundPage from "./pages/NotFoundPage";
import Login from "./pages/Login";
import Register from "./pages/Register";

function App() {
  return (
    <div>
      <BrowserRouter>
        <CustomNavbar></CustomNavbar>
        <Routes>
          <Route path="/" index element={<Home></Home>}></Route>
          <Route path="/home" index element={<Home></Home>}></Route>
          <Route path="/urun" element={<Product></Product>}></Route>
          <Route path="/urunler" element={<Products></Products>}></Route>
          <Route path="/profilim" element={<MyProfile></MyProfile>}></Route>
          <Route path="/sepetim" element={<MyCart></MyCart>}></Route>
          <Route path="/giris-yap" element={<Login></Login>}></Route>
          <Route path="/kayit-ol" element={<Register></Register>}></Route>
          <Route
            path="/favorilerim"
            element={<MyFavourites></MyFavourites>}
          ></Route>
          <Route path="*" element={<NotFoundPage></NotFoundPage>}></Route>
        </Routes>
        <CustomFooter></CustomFooter>
      </BrowserRouter>
    </div>
  );
}

export default App;
