import React, { useState, useEffect } from "react";
import axios from "axios";
import { useParams, useLocation, useNavigate } from "react-router-dom";
import "../Product/Product.css";
import ProductCard from "../../components/ProductCard";
import Pagination from "../../components/Pagination";
import { API_BASE_URL } from "../../config";

function SubcategoryPage() {
  const { subcategoryId } = useParams();
  const location = useLocation();
  const navigate = useNavigate();
  const [subcategory, setSubcategory] = useState({
    products: { items: [], totalPages: 1 },
  });
  const [selectedArrangement, setSelectedArrangement] = useState(1);
  const [currentPage, setCurrentPage] = useState(1);
  const [totalPages, setTotalPages] = useState(1);
  const [minPrice, setMinPrice] = useState(0);
  const [maxPrice, setMaxPrice] = useState(0);
  const [tempMinPrice, setTempMinPrice] = useState(0);
  const [tempMaxPrice, setTempMaxPrice] = useState(0);
  const imageUrl = "/images/cartImages/";

  useEffect(() => {
    const query = new URLSearchParams(location.search);
    const page = query.get("pageNumber") || 1;
    const orderBy = query.get("orderBy") || 1;
    const minPriceQuery = query.get("minPrice") || 0;
    const maxPriceQuery = query.get("maxPrice") || 0;
    setCurrentPage(Number(page));
    setSelectedArrangement(Number(orderBy));
    setMinPrice(Number(minPriceQuery));
    setMaxPrice(Number(maxPriceQuery));
    setTempMinPrice(Number(minPriceQuery));
    setTempMaxPrice(Number(maxPriceQuery));
  }, [location.search]);

  const handleSelectedArrangementChange = (event) => {
    const value = event.target.value;
    setSelectedArrangement(Number(value));
    setCurrentPage(1);

    const searchParams = new URLSearchParams(location.search);
    searchParams.set("orderBy", value);
    searchParams.set("pageNumber", 1);
    if (minPrice) searchParams.set("minPrice", minPrice);
    if (maxPrice) searchParams.set("maxPrice", maxPrice);
    navigate(`${location.pathname}?${searchParams.toString()}`);
  };

  const handlePriceFilterChange = () => {
    setMinPrice(tempMinPrice);
    setMaxPrice(tempMaxPrice);

    const searchParams = new URLSearchParams(location.search);
    searchParams.set("pageNumber", 1); // Filtre değiştiğinde sayfa numarasını 1'e ayarla
    searchParams.set("orderBy", selectedArrangement);
    if (tempMinPrice) searchParams.set("minPrice", tempMinPrice);
    if (tempMaxPrice) searchParams.set("maxPrice", tempMaxPrice);

    navigate(`${location.pathname}?${searchParams.toString()}`);
  };

  useEffect(() => {
    const fetchSubcategory = async () => {
      try {
        const response = await axios.get(
          `${API_BASE_URL}/Subcategories/get-subcategory-detail/${subcategoryId}?pageNumber=${currentPage}&orderBy=${selectedArrangement}&minPrice=${minPrice}&maxPrice=${maxPrice}`
        );
        setSubcategory(response.data);
        setTotalPages(response.data.products.totalPages);
      } catch (error) {
        console.error("Error fetching subcategory", error);
      }
    };

    fetchSubcategory();
  }, [subcategoryId, currentPage, selectedArrangement, minPrice, maxPrice]);

  const handlePageChange = (page) => {
    const searchParams = new URLSearchParams(location.search);
    searchParams.set("pageNumber", page);
    searchParams.set("orderBy", selectedArrangement);
    if (minPrice) searchParams.set("minPrice", minPrice);
    if (maxPrice) searchParams.set("maxPrice", maxPrice);

    navigate(`${location.pathname}?${searchParams.toString()}`);
    setCurrentPage(page);
  };

  return (
    <div className="products">
      <div className="products_categories">
        <p>
          <a href="/home">Anasayfa</a>
        </p>
        <i className="ri-arrow-right-s-line"></i>
        <p>
          <a href={`/c/${subcategory.categoryId}`}>
            {subcategory.categoryName}
          </a>
        </p>
        <i className="ri-arrow-right-s-line"></i>
        <p>{subcategory.name}</p>
      </div>
      <div
        style={{
          border: "1px solid gray",
          margin: ".5rem 0",
          width: "100%",
        }}
      ></div>
      <div className="products_allProducts">
        <div className="products_filterProducts">
          <div className="products_filterProducts-price">
            <p>
              <strong>Fiyat</strong>
            </p>
            <input
              type="number"
              placeholder="Min Fiyat"
              value={tempMinPrice}
              onChange={(e) => setTempMinPrice(Number(e.target.value))}
            />
            <input
              type="number"
              placeholder="Max Fiyat"
              value={tempMaxPrice}
              onChange={(e) => setTempMaxPrice(Number(e.target.value))}
            />
            <button onClick={handlePriceFilterChange}>Filtrele</button>
          </div>
        </div>
        <div className="products_productCardContainer">
          <div className="products_productTrailer">
            <h2>{subcategory.name}</h2>
            <p>{subcategory.description}</p>
          </div>
          <div className="products_filterRow">
            <p>
              <strong>{subcategory.products.totalCount}</strong> ürün
              listeleniyor.
            </p>
            <select
              value={selectedArrangement}
              onChange={handleSelectedArrangementChange}
            >
              <option value="1">Akıllı Sıralama</option>
              <option value="2">Ucuzdan Pahalıya</option>
              <option value="3">Pahalıdan Ucuza</option>
            </select>
          </div>

          <div className="products_productCards">
            {subcategory.products.items &&
            subcategory.products.items.length > 0 ? (
              subcategory.products.items.map((product) => (
                <ProductCard key={product.id} product={product} />
              ))
            ) : (
              <div>Seçtiğiniz alt kategoriye ait hiç ürün bulamadık.</div>
            )}
          </div>

          {subcategory.products.items &&
            subcategory.products.items.length > 0 && (
              <Pagination
                totalPages={totalPages}
                currentPage={currentPage}
                onPageChange={handlePageChange}
              />
            )}
        </div>
      </div>
    </div>
  );
}

export default SubcategoryPage;
