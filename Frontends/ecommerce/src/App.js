import { BrowserRouter, Route, Routes } from "react-router-dom";
import CustomNavbar from "./navbar/CustomNavbar";
import CustomFooter from "./components/CustomFooter";
import Home from "./pages/Home/Home";
import Product from "./pages/Product/Product";
import Products from "./pages/Products";
import MyProfile from "./pages/MyProfile/MyProfile";
import MyCart from "./pages/MyCart/MyCart";
import MyFavourites from "./pages/MyFavourites";
import NotFoundPage from "./pages/NotFoundPage";
import Login from "./pages/Login/Login";
import Register from "./pages/Register/Register";
import CategoryPage from "./pages/Category/CategoryPage";
import SubcategoryPage from "./pages/Subcategory/SubcategoryPage";

function App() {
  return (
    <div>
      <BrowserRouter>
        <CustomNavbar></CustomNavbar>
        <Routes>
          <Route path="/" index element={<Home></Home>}></Route>
          <Route path="/home" index element={<Home></Home>}></Route>
          <Route path="/urun/:productId" element={<Product></Product>}></Route>
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
          <Route
            path="/c/:categoryId"
            element={<CategoryPage></CategoryPage>}
          ></Route>
          <Route
            path="/sc/:subcategoryId"
            element={<SubcategoryPage></SubcategoryPage>}
          ></Route>
          <Route path="/kayit-ol" element={<Register></Register>}></Route>
        </Routes>
        <CustomFooter></CustomFooter>
      </BrowserRouter>
    </div>
  );
}

export default App;
