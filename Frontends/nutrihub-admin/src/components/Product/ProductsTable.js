import React, { useState, useEffect } from "react";
import { Button, Pagination, Table } from "react-bootstrap";
import { API_BASE_URL } from "../../config";
import { useNavigate, useLocation } from "react-router-dom";

const ProductsTable = ({ onEdit }) => {
  const [products, setProducts] = useState([]);
  const [currentPage, setCurrentPage] = useState(1);
  const [totalPages, setTotalPages] = useState(1);
  const [pageSize] = useState(5);

  const navigate = useNavigate();
  const location = useLocation();

  useEffect(() => {
    const params = new URLSearchParams(location.search);
    const page = params.get("pageNumber")
      ? parseInt(params.get("pageNumber"))
      : 1;
    const size = params.get("pageSize")
      ? parseInt(params.get("pageSize"))
      : pageSize;

    setCurrentPage(page);
    fetchProducts(page, size);
  }, [location.search]);

  const fetchProducts = (page, size) => {
    fetch(`${API_BASE_URL}/api/Products?pageNumber=${page}&pageSize=${size}`)
      .then((response) => response.json())
      .then((data) => {
        console.log(data);
        setProducts(data.items);
        setTotalPages(data.totalPages);
      })
      .catch((error) => console.error("Error fetching products:", error));
  };

  const handlePageChange = (page) => {
    setCurrentPage(page);
    navigate(`?pageNumber=${page}&pageSize=${pageSize}`);
  };

  const handleDeleteProduct = (productId) => {
    fetch(`${API_BASE_URL}/api/Products/${productId}`, {
      method: "DELETE",
    }).catch((error) => console.error("Error deleting product:", error));

    window.location.reload();
  };

  return (
    <>
      <Table striped bordered hover style={{ marginTop: "2rem" }}>
        <thead>
          <tr>
            <th>Ürün Görseli</th>
            <th>Ürün Adı</th>
            <th>Fiyat</th>
            <th>Stok</th>
            <th>Marka</th>
            <th>Kategori</th>
            <th>Alt Kategori</th>
            <th>Açıklama</th>
            <th>İşlemler</th>
          </tr>
        </thead>
        <tbody>
          {products.map((product) => (
            <tr key={product.id}>
              <td>
                <img
                  src={`${API_BASE_URL}${product.cardImageUrl}`}
                  alt={product.name}
                  style={{ width: "100px" }}
                />
              </td>
              <td>{product.name}</td>
              <td>{product.price}</td>
              <td>{product.stock}</td>
              <td>{product.brandName}</td>
              <td>{product.categoryName}</td>
              <td>{product.subcategoryName}</td>
              <td>{product.description}</td>
              <td>
                <Button variant="warning" onClick={() => onEdit(product)}>
                  Güncelle
                </Button>{" "}
                <Button
                  variant="danger"
                  onClick={() => handleDeleteProduct(product.id)}
                >
                  Sil
                </Button>
              </td>
            </tr>
          ))}
        </tbody>
      </Table>

      <Pagination>
        {Array.from({ length: totalPages }, (_, index) => (
          <Pagination.Item
            key={index + 1}
            active={index + 1 === currentPage}
            onClick={() => handlePageChange(index + 1)}
          >
            {index + 1}
          </Pagination.Item>
        ))}
      </Pagination>
    </>
  );
};

export default ProductsTable;
