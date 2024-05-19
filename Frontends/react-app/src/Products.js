import React, { useState } from "react";
import "../pages/Products.css";
import ProductCard from "../components/ProductCard";

function Products() {
  const [selectedArrangement, setSelectedArrangement] = useState("");

  const handleSelectedArrangementChange = (event) => {
    setSelectedArrangement(event.target.value);
  };
  return (
    <div className="products">
      <div className="products_categories">
        <p>Anasayfa</p>
        <i class="ri-arrow-right-s-line"></i>
        <p>Supplement</p>
        <i class="ri-arrow-right-s-line"></i>
        <p>Protein Tozu</p>
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
          <div className="products_filterProducts-subcategories">
            <p>
              <strong>Alt Kategori</strong>
            </p>
            <label>
              <input type="radio" name="supplier" value="Hiq" />
              {"  "}Hiq
            </label>
            <label>
              <input type="radio" name="supplier" value="Protein Ocean" />
              {"  "}Protein Ocean
            </label>
            <label>
              <input type="radio" name="supplier" value="Supplementler.com" />
              {"  "}Supplementler.com
            </label>
            <label>
              <input type="radio" name="supplier" value="Grizzone" />
              {"  "}Grizzone
            </label>
            <label>
              <input type="radio" name="supplier" value="Omega" />
              {"  "}Omega
            </label>
          </div>
          <div className="products_filterProducts-brand">
            <p>
              <strong>Marka</strong>
            </p>
            <label>
              <input type="radio" name="supplier" value="Hiq" />
              {"  "}Hiq
            </label>
            <label>
              <input type="radio" name="supplier" value="Protein Ocean" />
              {"  "}Protein Ocean
            </label>
            <label>
              <input type="radio" name="supplier" value="Supplementler.com" />
              {"  "}Supplementler.com
            </label>
            <label>
              <input type="radio" name="supplier" value="Grizzone" />
              {"  "}Grizzone
            </label>
            <label>
              <input type="radio" name="supplier" value="Omega" />
              {"  "}Omega
            </label>
          </div>
          <div className="products_filterProducts-price">
            <p>
              <strong>Fiyat</strong>
            </p>
            <input type="number" placeholder="Min Fiyat" />
            <input type="number" placeholder="Max Fiyat" />
            <button>Filtrele</button>
          </div>
        </div>
        <div className="products_productCardContainer">
          <div className="products_productTrailer">
            <h2>Protein Tozu</h2>
            <p>
              Peynir altı suyu olarak da bilinen whey protein tozu, hızlı emilim
              özelliği gösteren ve esansiyel amino asitler bakımından zengin
              olan yapısıyla sporcuların protein ihtiyacını en iyi şekilde
              karşılayan sporcu gıdalarından biridir. Peynir yapılırken
              pıhtılarından ayrılan sütün sıvı kısmının kullanıldığı whey
              protein tozu üretiminde, proteinin en çabuk sindirilebilen formu
              elde edilir. Bu formda tüketilen protein, vücutta kas kütlesinin
              artırılmasına ve kemiklerin normal fonksiyonlarının korunmasına
              destek olma işlevlerini ideal ölçüde yerine getirir.
            </p>
          </div>
          <div className="products_filterRow">
            <p>
              <strong>105</strong> ürün listeleniyor.
            </p>
            <select
              value={selectedArrangement}
              onChange={handleSelectedArrangementChange}
            >
              <option value="">Akıllı Sıralama</option>
              <option value="option1">Ucuzdan Pahalıya</option>
              <option value="option2">Pahalıdan Ucuza</option>
              <option value="option3">En Çok Beğenilen</option>
            </select>
          </div>
          <div className="products_productCards">
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
            <ProductCard></ProductCard>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Products;
