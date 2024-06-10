import React, { useState, useEffect } from "react";
import { Form } from "react-bootstrap";
import { API_BASE_URL } from "../../config";

const CategorySelector = ({ value, setCategoryId, setSubcategoryId }) => {
  const [data, setData] = useState([]);
  const [subcategories, setSubcategories] = useState([]);

  useEffect(() => {
    fetch(`${API_BASE_URL}/api/Categories/GetCategoriesMenu`)
      .then((response) => response.json())
      .then((data) => setData(data))
      .catch((error) => console.error("Error fetching data:", error));
  }, []);

  useEffect(() => {
    if (value.categoryId) {
      const selectedCategoryData = data.find(
        (category) => category.id === value.categoryId
      );
      setSubcategories(
        selectedCategoryData ? selectedCategoryData.subcategories : []
      );
    } else {
      setSubcategories([]);
    }
  }, [value.categoryId, data]);

  const handleCategoryChange = (e) => {
    const categoryId = parseInt(e.target.value);
    setCategoryId(categoryId);

    const selectedCategoryData = data.find(
      (category) => category.id === categoryId
    );
    setSubcategories(
      selectedCategoryData ? selectedCategoryData.subcategories : []
    );
    setSubcategoryId(""); // Alt kategoriyi sıfırla
  };

  const handleSubcategoryChange = (e) => {
    const subcategoryId = parseInt(e.target.value);
    setSubcategoryId(subcategoryId);
  };

  return (
    <div style={{ display: "flex", columnGap: "1rem", marginBottom: "1rem" }}>
      <Form.Select
        aria-label="Kategori seç"
        onChange={handleCategoryChange}
        value={value.categoryId}
      >
        <option value="">Kategori</option>
        {data.map((category) => (
          <option key={category.id} value={category.id}>
            {category.name}
          </option>
        ))}
      </Form.Select>

      <Form.Select
        aria-label="Alt Kategori seç"
        onChange={handleSubcategoryChange}
        value={value.subcategoryId}
        disabled={!value.categoryId}
      >
        <option value="">Alt Kategori</option>
        {subcategories.map((subcategory) => (
          <option key={subcategory.id} value={subcategory.id}>
            {subcategory.name}
          </option>
        ))}
      </Form.Select>
    </div>
  );
};

export default CategorySelector;
