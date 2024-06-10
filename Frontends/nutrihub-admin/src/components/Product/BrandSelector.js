import React, { useState, useEffect } from "react";
import { Form } from "react-bootstrap";
import { API_BASE_URL } from "../../config";

const BrandSelector = ({ value, setBrandId }) => {
  const [data, setData] = useState([]);

  useEffect(() => {
    fetch(`${API_BASE_URL}/api/Brands/brands-menu`)
      .then((response) => response.json())
      .then((data) => setData(data))
      .catch((error) => console.error("Error fetching data:", error));
  }, []);

  console.log("the current value is = ", value);
  return (
    <Form.Select
      className="mb-3"
      aria-label="Default select example"
      value={value}
      onChange={(e) => setBrandId(parseInt(e.target.value))}
    >
      <option value="">Marka Seç</option>
      {data.map((brand) => (
        <option key={brand.id} value={brand.id}>
          {brand.name}
        </option>
      ))}
    </Form.Select>
  );
};

export default BrandSelector;
