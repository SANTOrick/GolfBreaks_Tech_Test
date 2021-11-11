import { AdResponse } from "@/models/AdResponse";
import axios from "axios";


export default {

    getAds(): Promise<AdResponse> {
         console.log(process.env.VUE_APP_GOLFBREAKS_API_URL)

        const config = {
            headers: {
                "Access-Control-Allow-Origin": "*",
                "Access-Control-Allow-Methods": "GET, POST, PATCH, PUT, DELETE, OPTIONS",
                "Access-Control-Allow-Headers": "Origin, Content-Type, X-Auth-Token",
                "Content-Type": "application/json",
            }
        }

        return axios.get("http://localhost:5000/api/ads", config).then(response => {
            return response.data
        }).catch(error => console.log(error));
    }
}
