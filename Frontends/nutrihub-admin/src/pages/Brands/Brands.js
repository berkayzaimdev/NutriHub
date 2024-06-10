import { Button, Table } from "react-bootstrap";
import { API_BASE_URL } from "../../config";
import { useEffect, useState } from "react";
import swal from "sweetalert";
import axios from "axios";
import BrandModal from "../../components/Brand/BrandModal";

function Brands() {
  const [brands, setBrands] = useState([]);
  const [selectedBrand, setSelectedBrand] = useState(null);
  const [showBrandModal, setShowBrandModal] = useState(false);

  useEffect(() => {
    fetchBrands();
  }, []);

  const fetchBrands = () => {
    axios
      .get(`${API_BASE_URL}/api/Brands`)
      .then((response) => setBrands(response.data));
  };

  const handleShowBrandModal = (brand) => {
    setSelectedBrand(brand);
    setShowBrandModal(true);
  };

  const handleHideBrandModal = () => {
    setSelectedBrand(null);
    setShowBrandModal(false);
  };

  const handleDeleteBrand = async (id) => {
    await swal({
      title: "Emin misiniz?",
      text: "Silinen alt markayı tekrar geri alamazsınız!",
      icon: "warning",
      buttons: true,
      dangerMode: true,
    }).then((willDelete) => {
      if (willDelete) {
        axios
          .delete(`${API_BASE_URL}/api/Brands/${id}`)
          .then(window.location.reload());
      }
    });
  };

  return (
    <div style={{ padding: "2rem 6rem" }}>
      <div
        style={{
          display: "flex",
          justifyContent: "flex-start",
          marginBottom: "1rem",
        }}
      >
        <Button
          variant="primary"
          style={{ backgroundColor: "green", border: "none", width: "15rem" }}
          onClick={() => handleShowBrandModal()}
        >
          Marka Ekle
        </Button>
      </div>

      <Table striped bordered hover style={{ marginTop: "2rem" }}>
        <thead>
          <tr>
            <th>#</th>
            <th>Marka Görseli</th>
            <th>Marka Adı</th>
            <th>Marka Açıklaması</th>
            <th>İşlemler</th>
          </tr>
        </thead>
        <tbody>
          {brands.map((brand) => (
            <tr key={brand.id}>
              <td>{brand.id}</td>
              <td>
                {/**
                 * 
                 * <img
                  src={`${API_BASE_URL}${product.cardImageUrl}`}
                  alt={product.name}
                  style={{ width: "100px" }}
                  />
                 * 
                 */}
                <p>test</p>
              </td>
              <td>{brand.name}</td>
              <td>{brand.description}</td>
              <td>
                <Button
                  variant="warning"
                  onClick={() => handleShowBrandModal(brand)}
                >
                  Güncelle
                </Button>{" "}
                <Button
                  variant="danger"
                  onClick={() => handleDeleteBrand(brand.id)}
                >
                  Sil
                </Button>
              </td>
            </tr>
          ))}
        </tbody>
      </Table>

      {showBrandModal && (
        <BrandModal brand={selectedBrand} onClose={handleHideBrandModal} />
      )}
    </div>
  );
}

export default Brands;
